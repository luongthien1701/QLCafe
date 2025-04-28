using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                context.Account.Add(account);
                context.SaveChanges();
            }
        }
        public void editAccount(Account account)
        {
            using (var db = new MyDbContext())
            {
                var tmp = db.Account.FirstOrDefault(p => p.Username == account.Username);
                if (tmp != null)
                {
                    tmp.Password = account.Password;
                    tmp.Name = account.Name;
                    tmp.Phone = account.Phone;
                    db.SaveChanges();
                }
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
