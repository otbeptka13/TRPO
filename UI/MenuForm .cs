using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbPankovES.DomainObject;
namespace dbPankovES.UI
{
    public partial class MenuForm : Form
    {
        Seller seller;
        public MenuForm(int userId)
        {
            try
            {
                this.seller = new Seller(userId);
                seller.ErrorEvent += ErrorShow;
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }                 
        }
        private void ErrorShow(object sender, MessageEventArgs e)
        {
            MessageBox.Show(e.Message);
            // Close();
        }
        private void btSeller_Click(object sender, EventArgs e)
        {
                new SellerForm(seller).ShowDialog();
        }

        private void btShowOrdes_Click(object sender, EventArgs e)
        {
           new ShowOrdersForm(seller).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileStream = new BaseMethods().getFileStream();
            if (fileStream != null)
            {
                var suppliesLoad = seller.getSupplyFromFile(fileStream);
                if (suppliesLoad != null)
                    new SupplyForm(seller, suppliesLoad).ShowDialog();
            }
        }

        private void btNewGoods_Click(object sender, EventArgs e)
        {
            new ReportForm(seller).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new StatsForm(seller).ShowDialog();
        }
    }

}

