using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlycafe.DAL;
using Quanlycafe.DTO;
namespace Quanlycafe.BLL
{
    public class AccountBLL
    {
        private AccountDAL _accountDAL = new AccountDAL();
        public string login(string user, string pass)
        {
            Account account = _accountDAL.getAccount(user, pass);
            if (account != null)
            {
                return account.Role;
            }
            else return "";
        }
        public List<Account> getAccount()
        {
            return _accountDAL.getAccount();
        }
        public void addAccount(Account account)
        {
            _accountDAL.addAccount(account);
        }
        public void editAccount(Account account)
        {
            _accountDAL.editAccount(account);
        }
        public void removeAccount(string user)
        {
            _accountDAL.deleteAccount(user);
        }
    }

}
