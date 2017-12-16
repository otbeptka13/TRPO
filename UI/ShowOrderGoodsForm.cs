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
    public partial class ShowOrderGoodsForm : Form
    {
        private Seller seller;
        public ShowOrderGoodsForm(Seller seller, long? orderId)
        {
           
            InitializeComponent();
            this.seller = seller;
            if (orderId == null)
            {
                if (seller.ErrorEvent != null)
                    seller.ErrorEvent(this, new MessageEventArgs("Продавец не найден или не привязан ни к одному магазину!  Оформление заказов невозможно!"));
            }
            goodsBindingSource.DataSource = seller.GetOrderGoods((long)orderId);
      
        }
    }
}
