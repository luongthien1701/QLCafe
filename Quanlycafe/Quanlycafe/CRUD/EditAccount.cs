using Quanlycafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlycafe.BLL;
namespace Quanlycafe.CRUD
{
    public partial class EditAccount : Form
    {
        public EditAccount(string name,string user,string pass,string phone)
        {
            InitializeComponent();
            txtName.Text = name;
            txtUsername.Text = user;
            txtPassword.Text = pass;
            txtPhone.Text = phone;
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {

        }
        public void btnOK_Click(object sender, EventArgs e)
        {
            Account account = new Account
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Role = "user"
            };
            AccountBLL accountBLL = new AccountBLL();
            accountBLL.editAccount(account);
            this.Hide();
            Manager manager = new Manager();
            manager.reload_Account();
            manager.ShowDialog();
            this.Close();
        }
        public void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager manager = new Manager();
            manager.ShowDialog();
            this.Close();
        }
    }
}
