using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerLibrary
{
    public abstract class Account
    {
        // Holds BsB, Account Number, and Name for each account
        private string _bsb;
        private string _accountNumber;
        private string _name;

        public Account(string bsb, string account)
        {
            _bsb = bsb;
            _accountNumber = account;

        }

        // getter for BSB
        public string BSB
        {
            get
            {
                return _bsb;
            }
        }

        // getter for AccountNumber
        public string AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }

        // getter for Name
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        // Abstract value for balance, overridden by Interest + Savings Balance
        public abstract double Balance
        {
            get;
            set;
        }
    }
}
