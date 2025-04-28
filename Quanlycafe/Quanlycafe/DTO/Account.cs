using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlycafe.DTO
{
    [Table("Account")]
    public class Account
    {
        public string Name { get; set; }
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
    }
}
