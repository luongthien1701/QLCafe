using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlycafe.DTO;
using System.Data.Entity;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
namespace Quanlycafe.DAL
{
    public class ProductDAL
    {
        public List<Product> getproductType(int id_type)
        {
            using (var db = new MyDbContext())
            {
                return db.Product.Where(p => p.ID_Type == id_type).ToList();
            }
        }
        public List<Product> getallproduct()
        {
            using (var db = new MyDbContext())
            {
                return db.Product.Include(p=>p.Product_Type).ToList();
            }
        }
        public List<Product_Type> getalltype()
        {
            using (var db = new MyDbContext())
            {
                return db.Product_Type.ToList();
            }

        }
        public void addProduct(Product product)
        {
            using (var db = new MyDbContext())
            {
                db.Product.Add(product);
                db.SaveChanges();
            }
        }
        public void removeProduct(int id)
        {
            using (var db = new MyDbContext())
            {
                var tmp = db.Product.Find(id);
                if (tmp != null) 
                {
                    db.Product.Remove(tmp);
                    db.SaveChanges(); 
                }
            }
        }
        public void updateProduct(Product product)
        {
            using (var db=new MyDbContext()) 
            {
                var tmp = db.Product.Find(product.ID_Product);
                if (tmp != null)
                {
                    tmp.Name_Product=product.Name_Product;
                    tmp.Price=product.Price;
                    tmp.ID_Type=product.ID_Type;
                    tmp.Image = product.Image;
                    db.SaveChanges();
                }
            }
        }
        public int getProductID(string Name_Product)
        {
            using (var db = new MyDbContext())
            {
                return db.Product_Type.Where(p => p.Type == Name_Product).Select(p => p.ID_Type).FirstOrDefault();
            }
        }
        public string getpath(string name_Product)
        {
            using (var db = new MyDbContext())
            {
                return db.Product.Where(p => p.Name_Product == name_Product).Select(p => p.Image).FirstOrDefault();
            }
        }
        public void addProduct_Type(Product_Type producttype)
        {
            using (var db = new MyDbContext())
            {
                db.Product_Type.Add(producttype);
                db.SaveChanges();
            }
        }
        public void editProduct_Type(Product_Type producttype)
        {
            using (var db = new MyDbContext())
            {
                var tmp=db.Product_Type.Where(p=>p.ID_Type == producttype.ID_Type).FirstOrDefault();
                if (tmp != null)
                {
                    tmp.Type = producttype.Type;
                    db.SaveChanges();
                }
            }
        }
        public void removeProduct_Type(int id)
        {
            using (var db = new MyDbContext())
            {
                var tmp = db.Product_Type.Where(p=>p.ID_Type==id).FirstOrDefault();
                if (tmp != null)
                {
                    db.Product_Type.Remove(tmp);
                    db.SaveChanges();
                }
            }
        }
    }
}
