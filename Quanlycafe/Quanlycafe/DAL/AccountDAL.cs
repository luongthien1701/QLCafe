using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlycafe.DTO;

namespace Quanlycafe.DAL
{
    public class AccountDAL
    {
        public Account getAccount(string user, string pass)
        {

            using (var context = new MyDbContext())
            {
                return context.Account.FirstOrDefault(p => p.Username == user && p.Password == pass);
            }
        }
        public List<Account> getAccount()
        {
            using (var context = new MyDbContext())
            {
                return context.Account.ToList();
            }
        }
        public void addAccount(Account account)
        {
            using (var context = new MyDbContext())
            {
                var tmp = context.Account.FirstOrDefault(p => p.Username == account.Username||p.Phone==account.Phone);
                if (tmp != null)
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                }
                else
                {
                    context.Account.Add(account);
                    context.SaveChanges();
                    MessageBox.Show("Thêm tài khoản thành công");
                }
            }
        }
        public void editAccount(Account account)
        {
            using (var db = new MyDbContext())
            {
                var tmp = db.Account.FirstOrDefault(p=>p.Username==account.Username);
                if (tmp != null)
                {
                    tmp.Username = account.Username;
                    tmp.Password = account.Password;
                    tmp.Name = account.Name;
                    tmp.Phone = account.Phone;
                    db.SaveChanges();
                    MessageBox.Show("Cập nhật tài khoản thành công");
                }
                else { MessageBox.Show("Lỗi"); }
            }
        }
        public void deleteAccount(string user)
        {
            using (var db = new MyDbContext())
            {
                var tmp = db.Account.FirstOrDefault(p => p.Username == user);
                if (tmp != null)
                {
                    db.Account.Remove(tmp);
                    db.SaveChanges();
                }
            }
        }
    }
}
