using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlycafe.DAL;
using Quanlycafe.DTO;
namespace Quanlycafe.BLL
{
    public class Invoice_DetailBLL
    {
        private Invoice_DetailDAL _invoice_DetailDAL = new Invoice_DetailDAL();
        public List<Invoice_Detail> getallInvoice_Detail(int id)
        {
            return _invoice_DetailDAL.getallInvoice_Detail(id);
        }
        public void add(Invoice_Detail invoice_Detail)
        {
            _invoice_DetailDAL.add(invoice_Detail);
        }

    }
}
