using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBankerWPF
{
    public class User
    {
        private string _username;
        private string _password;
        List<Account> _accounts = new List<Account>();
        Account _activeAccount = null;
        public User(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string Username
        {
            get
            {
                return _username;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
        }

        public Account ActiveAccount
        {
            get
            {
                return _activeAccount;
            }
            set
            {
                _activeAccount = value;
            }
        }

        public List<Account> AccountList
        {
            get
            {
                return _accounts;
            }
        }


    }
}
