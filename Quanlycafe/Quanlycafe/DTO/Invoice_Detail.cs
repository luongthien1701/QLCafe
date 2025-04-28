using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlycafe.DTO
{
    [Table("Invoice_Detail")]
    public class Invoice_Detail
    {
        [Key]
        public string Name_Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int ID_Invoice { get; set; }
    }
}
