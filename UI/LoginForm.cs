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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            lbError.Text = string.Empty;
            var login = new Login();
            var userId = login.TryLogin(tbLogin.Text, tbPassword.Text);
            if (userId>0)
                new MenuForm((int)userId).ShowDialog();
            else lbError.Text = "Неверный логин или пароль!";
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin_Click(this, new EventArgs());
            }
        }
    }
}
