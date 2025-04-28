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
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }
        public void btnadd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
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
                accountBLL.addAccount(account);
                MessageBox.Show("Thêm tài khoản thành công");
                this.Hide();
                Manager manager = new Manager();
                manager.reload_Account();
                manager.ShowDialog();
                this.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager manager = new Manager();
            manager.ShowDialog();
            this.Close();
        }
    }
}
