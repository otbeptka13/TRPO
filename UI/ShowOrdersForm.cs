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
    public partial class ShowOrdersForm : Form
    {
        private Seller seller;
        public ShowOrdersForm(Seller seller)
        {          
            InitializeComponent();
            this.seller = seller;
            ordersViewBindingSource.DataSource = seller.getOrdersByPeriod(fromDate.Value.Date, null);
            lbWorker.Text = string.Format("Вы вошли под именем: {0}. Тип пользователя: {1}. Магазин: {2}", seller.Worker?.f + " " + seller.Worker?.i + " " + seller.Worker?.o,
                                                                        seller.Worker?.userTypeName, seller.Worker?.adress);
            lbWorker.Visible = true;

        }
        private void date_ValueChanged(object sender, EventArgs e)
        {
            var orders = seller.getOrdersByPeriod(fromDate.Value.Date, toDate.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59));
            if (chCustom.Checked)
                ordersViewBindingSource.DataSource = orders.Where(s => s.sellerId == seller.Worker.id);
            else
                ordersViewBindingSource.DataSource = orders;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var seletedOrderId = (dataGridView1.CurrentRow.DataBoundItem as OrdersView).id;
            new ShowOrderGoodsForm(seller, seletedOrderId).ShowDialog();
        }

        private void chCustom_CheckedChanged(object sender, EventArgs e)
        {
            var orders = seller.getOrdersByPeriod(fromDate.Value.Date, toDate.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59));
            if (chCustom.Checked)
                ordersViewBindingSource.DataSource = orders.Where(s => s.sellerId == seller.Worker.workerid);
            else
                ordersViewBindingSource.DataSource = orders;
        }
    }
}
