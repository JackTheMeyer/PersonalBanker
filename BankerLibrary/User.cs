using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerLibrary
{
    public class User
    {
        // Holds username, password, active accounts, and list of all accounts for uses
        private string _username;
        private string _password;
        List<Account> _accounts = new List<Account>();
        Account _activeAccount = null;
        public User(string username, string password)
        {
            _username = username;
            _password = password;
        }

        // getter for username
        public string Username
        {
            get
            {
                return _username;
            }
        }

        // getter for password
        public string Password
        {
            get
            {
                return _password;
            }
        }

        // getter for active account
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

        // getter AccountList
        public List<Account> AccountList
        {
            get
            {
                return _accounts;
            }
        }


    }
}
