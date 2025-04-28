using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlycafe.DTO
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ID_Product { get; set; }
        public string Name_Product { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("Product_Type")]
        public int ID_Type { get; set; }
        public string Image { get; set; }
        public virtual Product_Type Product_Type { get; set; }
    }
}
