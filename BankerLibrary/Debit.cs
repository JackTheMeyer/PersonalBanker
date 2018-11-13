using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerLibrary
{
    public class Debit : Transaction
    {
        // Holds amount to be debited, and target account for debit
        private double _debitAmount;
        private Account _reciever = null;

        public Debit(Account reciever, double amount) : base(reciever)
        {
            _debitAmount = amount;
            _reciever = reciever;
            
        }

        // Override for transaction abstract transact
        public override void transact()
        {
            _reciever.Balance -= _debitAmount;
        }

        // getter for debit amount
        public Double DebitAmount
        {
            get
            {
                return _debitAmount;
            }
            set
            {
                _debitAmount = value;
            }
        }
    }
}
