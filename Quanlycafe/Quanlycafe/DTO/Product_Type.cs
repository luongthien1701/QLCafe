using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlycafe.DTO
{
    [Table("Product_Type")]
    public class Product_Type
    {
        [Key]
        public int ID_Type { get; set; }
        public string Type { get; set; }
    }
}
