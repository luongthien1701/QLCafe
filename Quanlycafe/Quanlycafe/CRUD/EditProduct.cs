using Quanlycafe.DTO;
using System;
using System.Windows.Forms;
using Quanlycafe.BLL;
namespace Quanlycafe.CRUD
{
    public partial class EditProduct : Form
    {
        private ProductBLL productBLL = new ProductBLL();
        int _ID_Product;
        public EditProduct(int ID_Product,string Name_Product,string Price,string type_Product,string path)
        {
            InitializeComponent();
            _ID_Product = ID_Product;
            txtName.Text = Name_Product;
            txtPrice.Text = Price.ToString();
            cb1.Text = type_Product;
            txtPath.Text = path;
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
                    ID_Product = _ID_Product,
                    Name_Product = txtName.Text,
                    Price = Convert.ToInt32(txtPrice.Text),
                    ID_Type = productBLL.getID(cb1.Text),
                    Image = txtPath.Text
                };
                productBLL.update(product);
                this.Hide();
                Manager manager = new Manager();
                manager.reload();
                manager.ShowDialog();
                this.Close();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager manager = new Manager();
            manager.ShowDialog();
            this.Close();
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = FormatImagePath(openFileDialog.FileName);
            }
            this.Hide();
            Manager manager = new Manager();
            manager.reload();
            manager.ShowDialog();
            this.Close();
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
    }
}
