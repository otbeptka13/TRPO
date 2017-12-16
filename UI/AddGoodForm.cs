using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbPankovES.DomainObject.Models;
using dbPankovES.DomainObject;

namespace dbPankovES.UI
{
    public partial class AddGoodForm : Form
    {
        private Seller seller;
        public AddGoodForm(Seller seller)
        {
            InitializeComponent();
            this.seller = seller;
            goodTypesBindingSource.DataSource = seller.GoodsTypes;
            cbGoodType_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbGoodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTypeId =  (long) cbGoodType.SelectedValue;
            var goods = seller.GoodsView.Where(s => s.typeId == selectedTypeId).ToList();
            goodsViewBindingSource.DataSource = goods;
            cbGood_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void btAddGood_Click(object sender, EventArgs e)
        {
           
            var count = 0M;
            tbCount.Text = tbCount.Text.Replace(".", ",");
            if (decimal.TryParse(tbCount.Text, out count) == false || count <= 0)
            {
                if (seller.ErrorEvent != null)
                    seller.ErrorEvent(this, new MessageEventArgs("Некорректное значение количества товара"));               
                return;
            }
            
            var goodId =  (long)cbGood.SelectedValue;
            var countCapacity = seller.GetGoodCount(goodId);
            if (countCapacity < count)
                {
                if (seller.ErrorEvent != null)
                    seller.ErrorEvent(this, new MessageEventArgs("Указанное количество единиц товара больше, чем доступно на складе"));
                    return;
                }
            seller.AddBasket(goodId, count);
            this.Close();
        }

        private void cbGood_SelectedIndexChanged(object sender, EventArgs e)
        {
            var goodId = (long) cbGood.SelectedValue;
            var goodPrice = seller.GoodsView.FirstOrDefault(s => s.id == goodId)?.price;
            tbPrice.Text = goodPrice > 0 ? ((decimal)goodPrice).ToString("0.00") : "НЕОПРЕДЕЛЕНО";
            var count = seller.GetGoodCount(goodId);
            if (count != null)
                tbVailable.Text = count.ToString();
        }
    }
}
