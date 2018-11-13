using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerLibrary
{
    public abstract class Transaction
    {
        // Holds traget reciever account
        private Account _reciever;
        

        public Transaction(Account reciever)
        {
            
            _reciever = reciever;
        }

        // abstacrt transaction to be overriden by credit and debit
        public abstract void transact();


        // getter for reciever
        public Account Reciever
        {
            get
            {
                return _reciever;
            }
            set
            {
                _reciever = value;
            }
        }
    }
}
