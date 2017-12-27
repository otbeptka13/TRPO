using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbPankovES.DomainObject.Models;
using System.IO;

namespace dbPankovES.DomainObject
{

    public class Seller
    {
        private ShopWorkersView worker;
        public ShopWorkersView Worker { get { return worker; } }
        private List<GoodsView> goodsView;
        private List<GoodTypes> goodTypes;
        private List<Shops> shops;
        private List<NewSuply> newSupplies;
        public EventHandler<EventArgs> basketChange;
        public EventHandler<MessageEventArgs> ErrorEvent;
        public List<GoodSell> basket { get; set; }
        public Seller(int sellerId)
        {
            try
            {
                using (var db = new baseDataDataContext())
                {
                    goodsView = db.GoodsView?.ToList();
                    goodTypes = db.GoodTypes?.ToList();
                    shops = db.Shops.ToList();
                    worker = db.ShopWorkersView?.FirstOrDefault(s => s.workerid == sellerId);
                    basketChange += CounterBasket;
                }
            }
            catch (Exception ex)
            {
                if (ErrorEvent != null)
                    ErrorEvent(this, new MessageEventArgs(ex.Message));
            }
            if (worker == null)
                throw new Exception("Продавец не найден или не привязан ни к одному магазину!  Оформление заказов невозможно!");
        }

        public decimal GetSupplySum(DateTime fromDate, DateTime toDate)
        {
            try
            {
                using (var db = new baseDataDataContext())
                {
                    return db.SupplySumByDate(fromDate, toDate) ?? 0.00M;
                }
            }
            catch (Exception ex)
            {
                if (ErrorEvent != null)
                    ErrorEvent(this, new MessageEventArgs(ex.Message));
                return 0.00M;
            }
        }

        public List<CapacityView> getCapacityGoodsByShopId(long selectedShopId)
        {
            try
            {
                using (var db = new baseDataDataContext())
                {
                    var goodsCapacity = db.CapacityView.Where(s => s.shopId == (selectedShopId == 0 ? s.shopId : selectedShopId)).ToList();
                    if (selectedShopId == 0)
                    {
                       var  group = goodsCapacity.GroupBy(s => s.goodId);
                        goodsCapacity = new List<CapacityView>();
                        foreach (var items in group)
                        {
                            var sumCount = items.Sum(s => s.count);
                            var goodCap = items.FirstOrDefault();
                            goodCap.count = sumCount;
                            goodsCapacity.Add(goodCap);
                        }
                    }
                    return goodsCapacity;
                }
            }
            catch (Exception ex)
            {
                if (ErrorEvent != null)
                    ErrorEvent(this, new MessageEventArgs(ex.Message));
                return null;
            }
        }

        public bool SupplyUpload()
        {
            try
            {
                using (var db = new baseDataDataContext())
                {
                    var supplies = newSupplies.Select(s => new Supply
                    {
                        count = s.count,
                        created = DateTime.Now,
                        goodId = s.goodId,
                        shopId = s.shopId,
                        providerId = s.providerId,
                        supplyPriceOne = s.supplyPriceOne
                    });
                    db.Supply.InsertAllOnSubmit(supplies);
                    db.SubmitChanges();
                    newSupplies = null;
                    return true;
                }
            }
            catch (Exception ex)
            {
                if (ErrorEvent != null)
                    ErrorEvent(this, new MessageEventArgs(ex.Message));
                return false;
            }

        }
        public List<OrdersView> getOrdersByPeriod(DateTime fromDate, DateTime? toDate)
        {
            try
            {
                using (var db = new baseDataDataContext())
                {
                    var result = db.PaysByDate(fromDate, toDate)?.ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                if (ErrorEvent != null)
                    ErrorEvent(this, new MessageEventArgs(ex.Message));
                return null;
            }
        }
        public decimal? GetGoodCount(long goodId)
        {
            try
            {
                using (var db = new baseDataDataContext())
                {
                    var count = db.Capacity.FirstOrDefault(s => s.goodId == goodId && s.shopId == worker.shopId)?.count;
                    return count;
                }
            }
            catch (Exception ex)
            {
                if (ErrorEvent != null)
                    ErrorEvent(this, new MessageEventArgs(ex.Message));
                return null;
            }
        }
        public void AddBasket(long goodId, decimal count)
        {
            var good = GoodsView.Where(s => s.id == goodId).FirstOrDefault();
            var item = new GoodSell
            {

                goodId = good.id,
                goodName = good.name,
                priceOne = good.price,
                goodTypeName = good.typeName,
                count = count,
                summ = good.price * count,
                oneType = good.info
            };
            basket = basket ?? new List<GoodSell>();
            var goodInBasket = basket.Where(s => s.goodId == goodId).FirstOrDefault();
            if (goodInBasket != null)
            {
                goodInBasket.count += item.count;
                goodInBasket.summ += item.summ;
            }
            else
                basket.Add(item);

            if (basketChange != null)
                basketChange(this, EventArgs.Empty);
        }
        private void CounterBasket(object sender, EventArgs e)
        {
            if (basket?.Count() > 0)
                for (int i = 0; i < basket.Count(); i++)
                {
                    basket[i].id = i + 1;
                }
        }
        public bool CreateOder()
        {
            if (basket?.Count() > 0)
            {
                try
                {
                    using (var db = new baseDataDataContext())
                    {
                        foreach (var item in basket)
                        {
                            var capacityCount = GetGoodCount(item.goodId);
                            if (item.count > capacityCount)
                            {
                                if (ErrorEvent != null)
                                    ErrorEvent(this, new MessageEventArgs(string.Format("Количетство товара {0} ({1} ед.) больше чем доступно на складе ({2} ед.)!"
                                        , item.goodName, item.count, capacityCount)));
                                return false;
                            }
                        }

                        var orderId = db.CreateOrder(worker.workerid, worker.shopId, basket.Sum(s => s.summ), "cash", DateTime.Now);
                        if (orderId == 0)
                            throw new Exception();
                        foreach (var item in basket)
                        {
                            db.AddOrderGood(orderId, item.goodId, item.count, item.priceOne, item.summ);
                        }

                        basket = new List<GoodSell>();
                        if (basketChange != null)
                            basketChange(this, EventArgs.Empty);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    if (ErrorEvent != null)
                        ErrorEvent(this, new MessageEventArgs(ex.Message));
                    return false;
                }
            }
            return false;
        }
        public List<GoodSell> GetOrderGoods(long orderId)
        {
            try
            {
                using (var db = new baseDataDataContext())
                {
                    var orderGoods = db.OrderGoods.Where(s => s.orderId == orderId)
                                       .Select(s => new GoodSell
                                       {
                                           count = (decimal)s.count,
                                           goodId = s.goodId,
                                           goodName = s.Goods.name,
                                           goodTypeName = s.Goods.GoodTypes.name,
                                           priceOne = (decimal)s.priceOne,
                                           summ = (decimal)s.summ,
                                           oneType = s.Goods.info,

                                       }).ToList();
                    foreach (var item in orderGoods)
                    {
                        item.id = orderGoods.IndexOf(item) + 1;
                    }
                    return orderGoods;
                }
            }
            catch (Exception ex)
            {
                if (ErrorEvent != null)
                    ErrorEvent(this, new MessageEventArgs(ex.Message));
                return null;
            }
        }
        public List<SupplyView> getSupplyFromFile(Stream fileStream)
        {
            try
            {
                var errorMessage = string.Empty;
                using (var reader = new StreamReader(fileStream))
                {
                    var listSupply = new List<SupplyView>();
                    newSupplies = new List<NewSuply>();
                    int good = 0;
                    int all = 0;
                    while (!reader.EndOfStream)
                    {

                        var str = reader.ReadLine();
                        all++;
                        var stArr = str.Trim().Split(';');
                        //if (stArr.Length == 5)
                        {
                            try
                            {
                                var newSupply = new NewSuply
                                {
                                    providerId = long.Parse(stArr[0]),
                                    shopId = long.Parse(stArr[1]),
                                    goodId = long.Parse(stArr[2]),
                                    count = decimal.Parse(stArr[3].Replace('.', ',')),
                                    supplyPriceOne = decimal.Parse(stArr[4].Replace('.', ','))
                                };

                                using (var db = new baseDataDataContext())
                                {
                                    var g = db.Goods.First(s => s.id == newSupply.goodId);
                                    var sh = db.Shops.First(s => s.id == newSupply.shopId);
                                    var pr = db.Providers.First(s => s.id == newSupply.providerId);
                                    if (g != null && sh != null && pr != null)
                                    {
                                        var supply = new SupplyView
                                        {
                                            adress = sh.adress,
                                            goodId = g.id,
                                            goodInfo = g.info,
                                            goodName = g.name,
                                            price = g.price,
                                            typeName = g.name,
                                            shopId = sh.id,
                                            providerId = pr.id,
                                            name = pr.name,
                                            count = newSupply.count

                                        };
                                        good++;
                                        listSupply.Add(supply);
                                        newSupplies.Add(newSupply);
                                    }
                                    else
                                    {
                                        errorMessage += "Один из указанных ИД не определен в базе! Для: " + str + Environment.NewLine;
                                    }

                                }

                            }
                            catch (Exception ex)
                            {
                                errorMessage += "Не удалось разобрать строчку \"" + str + "\" " + ex.Message + Environment.NewLine;
                            }


                        }
                    }
                    if (listSupply.Count > 0 && good != all)
                        if (ErrorEvent != null)
                            ErrorEvent(this, new MessageEventArgs(errorMessage+"Загружено успешно " + good + " из " + all + " строк транспортного файла."));
                    return listSupply.Count > 0 ? listSupply : null;
                }
            }
            catch (Exception ex)
            {
                if (ErrorEvent != null)
                    ErrorEvent(this, new MessageEventArgs(ex.Message));
                return null;
            }

        }
        public List<GoodsView> GoodsView
        {
            get { return goodsView; }
        }
        public List<GoodTypes> GoodsTypes
        {
            get { return goodTypes; }
        }
        public List<Shops> Shops { get { return shops; } }
    }
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public MessageEventArgs(string msg) : base()
        {
            this.Message = msg;
        }
    }

}
