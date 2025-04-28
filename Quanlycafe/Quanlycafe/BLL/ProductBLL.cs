using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlycafe.DAL;
using Quanlycafe.DTO;
namespace Quanlycafe.BLL
{
    public class ProductBLL
    {
        ProductDAL productDAL = new ProductDAL();
        public List<Product> getproductType(string Name_Type)
        {
            using (var db = new MyDbContext())
            {
                var productType = db.Product_Type.FirstOrDefault(p => p.Type == Name_Type);
                if (productType == null)
                {
                    return new List<Product>();
                }
                return productDAL.getproductType(productType.ID_Type);
            }
        }
        public decimal CalculateTotal(DataGridView dgv)
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells[3].Value);
                }
            }
            return total;
        }

        public void ExportInvoice(string filePath, string tableName, DataGridView dgv, decimal cost, decimal vat, decimal total)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("=== HÓA ĐƠN THANH TOÁN ===");
                writer.WriteLine($"Ngày: {DateTime.Now}");
                writer.WriteLine("---------------------------");
                writer.WriteLine($"Bàn: {tableName}");

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;
                    string name = row.Cells[0].Value?.ToString();
                    string quantity = row.Cells[1].Value?.ToString();
                    string price = row.Cells[2].Value?.ToString();
                    string rowTotal = row.Cells[3].Value?.ToString();

                    writer.WriteLine($"{name} - SL: {quantity} - Đơn giá: {price} - Thành tiền: {rowTotal}");
                }

                writer.WriteLine("---------------------------");
                writer.WriteLine($"Tạm tính: {cost} VND");
                writer.WriteLine($"VAT (8%): {vat} VND");
                writer.WriteLine($"Tổng cộng: {total} VND");
                writer.WriteLine("===========================");
            }
        }
        public int getID(string Name_Type)
        {
            return productDAL.getProductID(Name_Type);
        }
        public List<Product> getallproduct()
        {
           
            return productDAL.getallproduct();
        }
        public List<Product_Type> getalltype()
        {
            return productDAL.getalltype();
        }
        public void addProduct(Product product)
        {
            productDAL.addProduct(product);
        }
        public void remove(int id)
        {
            productDAL.removeProduct(id);
        }
        public void update(Product product)
        {
            productDAL.updateProduct(product);
        }
        public string getImagePath(string name)
        {
            using (var db = new MyDbContext())
            {
                return productDAL.getpath(name);
            }
        }
        public void addProduct_Type(Product_Type product_Type)
        {
            productDAL.addProduct_Type(product_Type);
        }
        public void removeProduct_Type(int id)
        {
            productDAL.removeProduct_Type(id);
        }
    }
}
