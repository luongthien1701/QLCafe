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
    public partial class DetailInvoice : Form
    {
        public DetailInvoice(int id,string day,int table,int total)
        {
            InitializeComponent();
            Invoice_DetailBLL invoice_DetailBLL = new Invoice_DetailBLL();
            txtDay.Text = day;
            txtTable.Text = table.ToString();
            txtTotal.Text = total.ToString();
            List<Invoice_Detail> _invoice_Details = invoice_DetailBLL.getallInvoice_Detail(id);
            dgv.Rows.Clear();
            foreach (var invoice_Detail in _invoice_Details)
            {
                dgv.Rows.Add(invoice_Detail.Name_Product, invoice_Detail.Quantity, invoice_Detail.Price);
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager manager = new Manager();
            manager.ShowDialog();
            this.Close();
        }

    }
}
