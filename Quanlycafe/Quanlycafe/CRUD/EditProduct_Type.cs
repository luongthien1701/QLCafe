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
using Quanlycafe.DTO;
namespace Quanlycafe.CRUD
{
    public partial class EditProduct_Type : Form
    {
        public EditProduct_Type(int id, string name_type)
        {
            InitializeComponent();
            txtID.Text = id.ToString();
            txtName_Type.Text = name_type;
        }
        public void btnOK_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtName_Type.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                string name_type = txtName_Type.Text;
                Product_Type product_Type = new Product_Type
                {
                    Type = name_type
                };
                ProductBLL productBLL = new ProductBLL();
                productBLL.addProduct_Type(product_Type);
                this.Hide();
                Manager manager = new Manager();
                manager.reload_ProductType();
                manager.ShowDialog();
                this.Close();
            }
        }
        public void btnCancle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager manager = new Manager();
            manager.reload_ProductType();
            manager.ShowDialog();
            this.Close();
        }

    }
}
