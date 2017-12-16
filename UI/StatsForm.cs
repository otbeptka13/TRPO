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
    public partial class StatsForm : Form
    {
        private Seller seller;
        public StatsForm(Seller seller)
        {          
            InitializeComponent();
            this.seller = seller;
            fromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            
        }
        private void date_ValueChanged(object sender, EventArgs e)
        {
            var orders = seller.getOrdersByPeriod(fromDate.Value.Date, toDate.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59));
            var ordersCount = orders?.Count ?? 0;
            var orderSum = orders?.Sum(s => s.price) ?? 0.00M;
            var supllySum = seller.GetSupplySum(fromDate.Value.Date, toDate.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59));
            var capital = orderSum - supllySum;
            lbCount.Text = ordersCount.ToString();
            lbOrderSum.Text = orderSum.ToString("0.00") + " руб.";
            lbSupplySum.Text = supllySum.ToString("0.00") + " руб.";
            lbCapital.Text = capital.ToString("0.00") + " руб.";
        }
     
    }
}
