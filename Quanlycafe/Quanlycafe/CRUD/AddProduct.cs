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
namespace Quanlycafe
{
    public partial class AddProduct : Form
    {
        private ProductBLL productBLL = new ProductBLL();
        public AddProduct()
        {
            InitializeComponent();
            List<Product_Type> productTypes = productBLL.getalltype();
            foreach (var type in productTypes)
            {
                cb1.Items.Add(type.Type);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPath.Text == "" || txtPrice == null || cb1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.");
                return;
            }
            else
            {
                Product product = new Product
                {
                    Name_Product = txtName.Text,
                    Price = Convert.ToInt32(txtPrice.Text),
                    ID_Type = productBLL.getID(cb1.Text),
                    Image = txtPath.Text
                };
                productBLL.addProduct(product);
                this.Hide();
                Manager manager = new Manager();
                manager.reload();
                manager.ShowDialog();
                this.Close();
            }
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = FormatImagePath(openFileDialog.FileName);
            }
        }
        public string FormatImagePath(string fullPath)
        {
            var index = fullPath.IndexOf("Resource\\");
            if (index >= 0)
            {
                return fullPath.Substring(index);
            }
            return fullPath;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager manager = new Manager();
            manager.ShowDialog();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
