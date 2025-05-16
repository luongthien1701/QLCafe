using Quanlycafe.BLL;
using Quanlycafe.DTO;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Quanlycafe
{
    public partial class Staff : Form
    {
        ProductBLL productBLL = new ProductBLL();
        InvoiceBLL _InvoiceBLL = new InvoiceBLL();
        Invoice_DetailBLL _invoice_DetailBLL = new Invoice_DetailBLL();

        public Staff()
        {
            InitializeComponent();
            string typeName = tabControl.SelectedTab.Text;
            LoadProducts(typeName, tabControl.SelectedTab);
        }

        private void tabPageControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typeName = tabControl.SelectedTab.Text;
            LoadProducts(typeName, tabControl.SelectedTab);
        }

        void LoadProducts(string typeName, TabPage tabPage)
        {
            var flow = tabPage.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
            if (flow == null) return;

            flow.Controls.Clear();
            var products = productBLL.getproductType(typeName);

            foreach (var p in products)
            {
                Panel panel = new Panel { Width = 150, Height = 230, BorderStyle = BorderStyle.FixedSingle };

                PictureBox pic = new PictureBox
                {
                    Image = Image.FromFile(p.Image),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Top,
                    Height = 100
                };
                panel.Controls.Add(pic);

                Label nameLabel = new Label
                {
                    Text = p.Name_Product,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.White,
                    Height = 30
                };
                panel.Controls.Add(nameLabel);

                Label priceLabel = new Label
                {
                    Text = $"{p.Price} VND",
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.White,
                    Height = 30
                };
                panel.Controls.Add(priceLabel);

                Panel buttonsPanel = new Panel
                {
                    Dock = DockStyle.Bottom,
                    Height = 40
                };

                Button btnAdd = new Button
                {
                    Text = "+",
                    Width = 60,
                    Dock = DockStyle.Right,
                    BackColor = Color.LightGreen
                };
                btnAdd.Click += (s, e) =>
                {
                    bool found = false;
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.Cells[0].Value?.ToString() == p.Name_Product)
                        {
                            int quantity = Convert.ToInt32(row.Cells[1].Value);
                            quantity++;
                            row.Cells[1].Value = quantity;
                            row.Cells[3].Value = quantity * p.Price;
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        dgv.Rows.Add(p.Name_Product, 1, p.Price, p.Price);
                    }
                    LoadProducts(typeName, tabControl.SelectedTab);
                    UpdateCost();
                };
                buttonsPanel.Controls.Add(btnAdd);

                var existingRow = dgv.Rows
                    .Cast<DataGridViewRow>()
                    .FirstOrDefault(r => r.Cells[0].Value?.ToString() == p.Name_Product && Convert.ToInt32(r.Cells[1].Value) > 0);

                if (existingRow != null)
                {
                    Button btnMinus = new Button
                    {
                        Text = "-",
                        Width = 60,
                        Dock = DockStyle.Left,
                        BackColor = Color.LightCoral
                    };
                    btnMinus.Click += (s, e) =>
                    {
                        int quantity = Convert.ToInt32(existingRow.Cells[1].Value);
                        if (quantity > 1)
                        {
                            quantity--;
                            existingRow.Cells[1].Value = quantity;
                            existingRow.Cells[3].Value = quantity * p.Price;
                        }
                        else
                        {
                            dgv.Rows.Remove(existingRow);
                            LoadProducts(typeName, tabControl.SelectedTab);
                        }
                        UpdateCost();
                    };
                    buttonsPanel.Controls.Add(btnMinus);
                }

                panel.Controls.Add(buttonsPanel);
                flow.Controls.Add(panel);
            }
        }

        void UpdateCost()
        {
            decimal tong = productBLL.CalculateTotal(dgv);
            lbCost.Text = tong.ToString();
            lbVAT.Text = (tong * 8 / 100).ToString();
            lbTotal.Text = (tong + (tong * 8 / 100)).ToString();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            lbCost.Text = "0";
            lbVAT.Text = "0";
            lbTotal.Text = "0";
            txt1.Text = "";
            string typeName = tabControl.SelectedTab.Text;
            LoadProducts(typeName, tabControl.SelectedTab);
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập bàn");
                return;
            }
            if (lbCost.Text == "0") 
            {
                MessageBox.Show("Hóa đơn rỗng");
                return;
            }
            DateTime dt = DateTime.Now;
            func(dt);
            string day = dt.Day.ToString() + "/" + dt.Month + "/" + dt.Year;
            string time = dt.Hour + ":" + dt.Minute + ":" + dt.Second;
            Invoice invoice = new Invoice
            {
                Day = day,
                Table = Convert.ToInt32(txt1.Text),
                ToTal = Convert.ToInt32(lbCost.Text),
                Time = time
            };
            _InvoiceBLL.addInvoice(invoice);
            int id = _InvoiceBLL.getId_Invoice();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;
                string name = row.Cells[0].Value?.ToString();
                string quantity = row.Cells[1].Value?.ToString();
                string price = row.Cells[2].Value?.ToString();
                Invoice_Detail invoice_Detail = new Invoice_Detail
                {
                    Name_Product = name,
                    Quantity = Convert.ToInt32(quantity),
                    Price = Convert.ToInt32(price),
                    ID_Invoice = id,
                };
                _invoice_DetailBLL.add(invoice_Detail);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog{Filter = "Text Files (*.txt)|*.txt"};
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                productBLL.ExportInvoice(
                    saveFileDialog.FileName,
                    txt1.Text,
                    dgv,
                    decimal.Parse(lbCost.Text),
                    decimal.Parse(lbVAT.Text),
                    decimal.Parse(lbTotal.Text)
                );
                MessageBox.Show("Xuất hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void func(DateTime dt)
        {
            int _day = dt.Day;
            int _month = dt.Month;
            int _year = dt.Year;
            int _hour = dt.Hour;
            int _minute = dt.Minute;
            int _second = dt.Second;
        }
        private void btnExit(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
