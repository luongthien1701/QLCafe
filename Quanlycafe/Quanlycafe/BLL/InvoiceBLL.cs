using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlycafe.DAL;
using Quanlycafe.DTO;
namespace Quanlycafe.BLL
{
    public class InvoiceBLL
    {
        private InvoiceDAL _invoiceDAL = new InvoiceDAL();
        public List<Invoice> getInvoice()
        {
            return _invoiceDAL.getallInvoice();
        }
        public List<Invoice> getInvoice(int table, string day)
        {
            return _invoiceDAL.getInvoice(table, day);
        }
        public void addInvoice(Invoice invoice)
        {
            _invoiceDAL.addInvoice(invoice);
        }
        public int getId_Invoice()
        {
            return _invoiceDAL.getId_Invoice();
        }
    }
}
