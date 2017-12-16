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
    public partial class SupplyForm : Form
    {
        private Seller seller;
        public SupplyForm(Seller seller, List<SupplyView> supplies)
        {          
            InitializeComponent();
            this.seller = seller;
            bindingSource1.DataSource = supplies;
        }

        private void btSupply_Click(object sender, EventArgs e)
        {
            if(seller.SupplyUpload())
            {
                if (seller.ErrorEvent != null)
                    seller.ErrorEvent(this, new MessageEventArgs("Данные по поставке успешно выгружены в базу"));
                this.Close();
            }
        }
    }
}
