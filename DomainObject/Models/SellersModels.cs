using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbPankovES.DomainObject.Models
{
    public class Basket
    {
        public List<GoodSell> goods { get; set; }
    }
    public class GoodSell
    {
        [DisplayName("№")]
        public int id { get; set; }
        [DisplayName("Идентификатор товара")]
        public long goodId { get; set; }
        [DisplayName("Наименование товара")]
        public string goodName { get; set; }
        [DisplayName("Тип товара")]
        public string goodTypeName { get; set; }
        [DisplayName("Количество единиц товара")]
        public decimal count { get; set; }
        [DisplayName("Цена за единицу")]
        public decimal priceOne { get; set; }
        [DisplayName("Ед.изм.")]
        public string oneType { get; set; }
        [DisplayName("Сумма")]
        public decimal summ { get; set; }
    }

    public class NewSuply
    {
        [DisplayName("ИД провайдера")]
        public long providerId { get; set; }
        [DisplayName("ИД магазина")]
        public long shopId { get; set; }
        [DisplayName("ИД товара")]
        public long goodId { get; set; }
        [DisplayName("Кол-во ед-ц товара")]
        public decimal count { get; set; }
        [DisplayName("Цена за ед-цу")]
        public decimal supplyPriceOne { get; set; }
    }

}