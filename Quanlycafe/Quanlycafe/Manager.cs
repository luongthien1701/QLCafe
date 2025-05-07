using Quanlycafe.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlycafe.DTO;
using Quanlycafe.CRUD;
namespace Quanlycafe
{
    public partial class Manager : Form
    {
        private ProductBLL productBLL = new ProductBLL();
        private AccountBLL _accountBLL = new AccountBLL();
        private InvoiceBLL _invoiceBLL = new InvoiceBLL();

        public Manager()
        {
            InitializeComponent();
            reload();
            reload_ProductType();
            reload_Account();
            reload_Invoice();
        }
        public void reload_Invoice()
        {
            dgv4.Rows.Clear();
            List<Invoice> invoices = _invoiceBLL.getInvoice();
            foreach (var invoice in invoices)
            {
                dgv4.Rows.Add(invoice.ID_Invoice, invoice.Day, invoice.Table, invoice.ToTal,invoice.Time);
            }
        }
        public void reload_Account()
        {
            dgv3.Rows.Clear();
            List<Account> accounts = _accountBLL.getAccount();
            foreach (var account in accounts)
            {
                dgv3.Rows.Add(account.Name, account.Username, account.Password, account.Phone);
            }
        }
        public void reload_ProductType()
        {
            dgv2.Rows.Clear();
            List<Product_Type> productTypes = productBLL.getalltype();
            foreach (var type in productTypes)
            {
                dgv2.Rows.Add(type.ID_Type, type.Type);
            }
        }
        public void reload()
        {
            dgv.Rows.Clear();
            List<Product> products = productBLL.getallproduct();
            foreach (var product in products)
            {
                dgv.Rows.Add(product.ID_Product, product.Name_Product, product.Price, product.Product_Type.Type);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value);
                string productName = row.Cells[1].Value.ToString();
                string productPrice = row.Cells[2].Value.ToString();
                string productType = row.Cells[3].Value.ToString();
                string path = productBLL.getImagePath(productName);
                this.Hide();
                EditProduct editProduct = new EditProduct(id, productName, productPrice, productType, path);
                editProduct.ShowDialog();
                this.Close();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    productBLL.remove(id);
                }
            }
            dgv.Rows.Clear();
            reload();
        }

        private void btnadd_ProductType_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct_Type addProduct_Type = new AddProduct_Type();
            addProduct_Type.ShowDialog();
            this.Close();
        }
        private void btedit_ProductType_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgv2.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value);
                string typeName = row.Cells[1].Value.ToString();
                this.Hide();
                EditProduct_Type editProduct_Type = new EditProduct_Type(id, typeName);
                editProduct_Type.ShowDialog();
                this.Close();
            }
        }
        private void btndelete_ProductType_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv2.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    productBLL.removeProduct_Type(id);
                }
                reload_ProductType();
            }
        }


        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAccount addAccount = new AddAccount();
            addAccount.ShowDialog();
            this.Close();
        }
        private void btnEditAccount_Click(Object sender, EventArgs e)
        {
            this.Hide();
            if (dgv3.SelectedRows.Count == 1)
            {
                string name = dgv3.SelectedRows[0].Cells[0].Value.ToString();
                string user = dgv3.SelectedRows[0].Cells[1].Value.ToString();
                string pass = dgv3.SelectedRows[0].Cells[2].Value.ToString();
                string phone = dgv3.SelectedRows[0].Cells[3].Value.ToString();
                EditAccount editAccount = new EditAccount(name, user, pass, phone);
                editAccount.ShowDialog();
                this.Close();
            }
        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (dgv3.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv3.SelectedRows)
                {
                    string user = row.Cells[1].Value.ToString();
                    _accountBLL.removeAccount(user);
                }
                reload_Account();
            }
        }


        private void cbday_Click(object sender, EventArgs e)
        {
            if (cbmonth.Text == "" || cbyear.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tháng và năm trước");
                return;
            }
            cbday.Items.Clear();
            bool check = false;
            int[] _day = null;

            if (Convert.ToInt32(cbyear.Text) % 4 == 0 && (Convert.ToInt32(cbyear.Text) % 100 != 0) || ((Convert.ToInt32(cbyear.Text) % 400 == 0)))
            {
                check = true;
            }

            if (Convert.ToInt32(cbmonth.Text) == 1 || Convert.ToInt32(cbmonth.Text) == 3 || Convert.ToInt32(cbmonth.Text) == 5 || Convert.ToInt32(cbmonth.Text) == 7 || Convert.ToInt32(cbmonth.Text) == 8 || Convert.ToInt32(cbmonth.Text) == 10 || Convert.ToInt32(cbmonth.Text) == 12)
            {
                _day = Enumerable.Range(1, 31).ToArray();
            }
            else if (Convert.ToInt32(cbmonth.Text) == 2)
            {
                _day = check ? Enumerable.Range(1, 29).ToArray() : Enumerable.Range(1, 28).ToArray();
            }
            else
            {
                _day = Enumerable.Range(1, 30).ToArray();
            }
            cbday.Items.AddRange(_day.Cast<object>().ToArray());
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            int table = (txtTable.Text == "" ? 0 : Convert.ToInt32(txtTable.Text));
            string day = "";
            if (cbday.Text != "" && cbmonth.Text != "" && cbyear.Text != "")
            {
                day = cbday.Text + "/" + cbmonth.Text + "/" + cbyear.Text;
            }

            dgv4.Rows.Clear();
            List<Invoice> invoices = _invoiceBLL.getInvoice(table, day);
            foreach (var invoice in invoices)
            {
                dgv4.Rows.Add(invoice.ID_Invoice, invoice.Day, invoice.Table, invoice.ToTal,invoice.Time);
            }
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dgv4.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgv4.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value);
                string day = row.Cells[1].Value.ToString();
                int table = Convert.ToInt32(row.Cells[2].Value);
                int total = Convert.ToInt32(row.Cells[3].Value);
                this.Hide();
                DetailInvoice detailInvoice = new DetailInvoice(id,day,table,total);
                detailInvoice.ShowDialog();
                this.Close();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }
    }
}
