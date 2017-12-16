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
    public partial class ReportForm : Form
    {
        private Seller seller;
        public ReportForm(Seller seller)
        {          
            InitializeComponent();
            this.seller = seller;
            var shops = seller.Shops;
            shops.Add(new Shops { id = 0, adress = "ВСЕ" });
            shopsBindingSource.DataSource = shops;
            cbShops_SelectedIndexChanged(this, EventArgs.Empty);
            // ordersViewBindingSource.DataSource = seller.getOrdersByPeriod(fromDate.Value.Date, null);

        }

        private void cbShops_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedShopId = (long)cbShops.SelectedValue;
            var goodCapacity = seller.getCapacityGoodsByShopId(selectedShopId);
            dataGridView1.DataSource = goodCapacity;
        }
    }
}
