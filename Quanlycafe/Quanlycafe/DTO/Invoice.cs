using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlycafe.DTO
{
    [Table("Invoice")]
    public class Invoice
    {
        [Key]
        public int ID_Invoice { get; set; }
        public string Day { get; set; }
        public int Table { get; set; }
        public int ToTal { get; set; }
        public string Time { get; set; }
    }
}
