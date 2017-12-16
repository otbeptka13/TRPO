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
    public partial class SellerForm : Form
    {
        private Seller seller;
        public SellerForm(Seller seller)
        {          
            InitializeComponent();
            this.seller = seller;
            seller.basketChange += BasketChange;          
            goodsBindingSource.DataSource = seller.basket;
            lbWorker.Text = string.Format("Вы вошли под именем: {0}. Тип пользователя: {1}. Магазин: {2}", seller.Worker?.f + " " + seller.Worker?.i + " " + seller.Worker?.o,
                                                                        seller.Worker?.userTypeName, seller.Worker?.adress);
            lbWorker.Visible = true;

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (seller.basket?.Count > 0)
            {
                var result = seller.CreateOder();
                if (!result)
                    lbError.Text = "Ошибка создания заказа!";
                else
                {
                    lbError.Text = string.Empty;

                }
            }
        }

        private void btAddGood_Click(object sender, EventArgs e)
        {
            new AddGoodForm(seller).ShowDialog();
        }
        private void BasketChange(object sender, EventArgs e)
        {
            goodsBindingSource.DataSource = null;
            goodsBindingSource.DataSource = seller.basket;
            if (seller.basket?.Count() > 0)
            {
                lbItog.Visible = true;
                lbTexItog.Visible = true;
                lbItog.Text = seller.basket.Sum(s => s.summ).ToString("0.00");
            }
            else
                lbItog.Visible = lbTexItog.Visible = false;
        }       
        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            seller.basket = goodsBindingSource.DataSource as List<GoodSell>;
            if (seller.basketChange != null)
                seller.basketChange(this, EventArgs.Empty);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            goodsBindingSource.DataSource = seller.basket = new List<GoodSell>();
            if (seller.basketChange != null)
                seller.basketChange(this, EventArgs.Empty);
        }
    }
}
