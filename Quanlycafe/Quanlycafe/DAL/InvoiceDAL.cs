using Quanlycafe.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlycafe.DAL
{
    public class InvoiceDAL
    {
        public List<Invoice> getallInvoice()
        {
            using (var db = new MyDbContext())
            {
                return db.Invoice.ToList();
            }
        }
        public List<Invoice> getInvoice(int table, string day)
        {
            using (var db = new MyDbContext())
            {
                if (table == 0)
                {
                    return db.Invoice.Where(p => p.Day == day).ToList();
                }
                else if (day == "")
                {
                    return db.Invoice.Where(p => p.Table == table).ToList();
                }
                else if (table == 0 && day == "")
                {
                    return db.Invoice.ToList();
                }
                else
                {
                    return db.Invoice.Where(p => p.Table == table && p.Day == day).ToList();
                }
            }
        }
        public void addInvoice(Invoice invoice)
        {
            using (var db = new MyDbContext())
            {
                db.Invoice.Add(invoice);
                db.SaveChanges();
            }
        }
        public int getId_Invoice()
        {
            using (var db = new MyDbContext())
            {
                return db.Invoice.Max(p => p.ID_Invoice);
            }
        }
    }
}
