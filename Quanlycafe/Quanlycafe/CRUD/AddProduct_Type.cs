using Quanlycafe.BLL;
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

namespace Quanlycafe.CRUD
{
    public partial class AddProduct_Type : Form
    {
        public AddProduct_Type()
        {
            InitializeComponent();
        }
        private void btnOK_Click(Object sender,EventArgs e)
        {
            if (txtID.Text==""||txtName_Type.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                Product_Type product_Type = new Product_Type
                {
                    ID_Type = Convert.ToInt32(txtID.Text),
                    Type = txtName_Type.Text
                };
                ProductBLL productBLL = new ProductBLL();
                productBLL.addProduct_Type(product_Type);
                MessageBox.Show("Thêm thành công");
                this.Hide();
                Manager manager = new Manager();
                manager.reload_ProductType();
                manager.ShowDialog();
                this.Close();
            }
        }
        private void btnCancel_Click(Object sender, EventArgs e)
        {
            this.Hide();
            Manager manager = new Manager();
            manager.ShowDialog();
            this.Close();
        }

    }
}
