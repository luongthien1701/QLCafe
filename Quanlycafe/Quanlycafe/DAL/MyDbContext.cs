using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using Quanlycafe.DTO;
namespace Quanlycafe.DAL
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=Model1")
        {
        }
        public DbSet<Account> Account { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Product_Type> Product_Type { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Invoice_Detail> Invoice_Detail { get; set; }
    }
}
