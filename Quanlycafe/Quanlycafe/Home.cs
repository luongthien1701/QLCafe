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
namespace Quanlycafe
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = txtus.Text;
            String pass = txtpass.Text;
            if (user == "" || pass == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                AccountBLL userBLL = new AccountBLL();
                String role = userBLL.login(user, pass);
                if (role == "manager")
                {
                    this.Hide();
                    Manager form2 = new Manager();
                    form2.ShowDialog();
                }
                else if (role == "staff")
                {
                    this.Hide();
                    Staff form3 = new Staff();
                    form3.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                }
            }
        }
    }
}
