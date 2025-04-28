using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlycafe.DTO;
namespace Quanlycafe.DAL
{
    public class Invoice_DetailDAL
    {
        public List<Invoice_Detail> getallInvoice_Detail(int id)
        {
            using (var db = new MyDbContext())
            {
                return db.Invoice_Detail.Where(p=>p.ID_Invoice==id).ToList();
            }
        }
        public void add(Invoice_Detail invoice_Detail)
        {
            using (var db = new MyDbContext())
            {
                db.Invoice_Detail.Add(invoice_Detail);
                db.SaveChanges();
            }
        }
    }
}
