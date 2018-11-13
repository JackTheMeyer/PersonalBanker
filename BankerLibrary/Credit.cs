using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerLibrary
{
    public class Credit : Transaction
    {
        // Credit amount refered to amount being crediter, reciever is the account targeted for transaction
        private double _creditAmount = new double();
        private Account _reciever = null;

        public Credit(Account reciever, double amount) : base(reciever)
        {
            _creditAmount = amount;
            _reciever = _reciever as Savings;
            _reciever = reciever;
        }


        //getter for credit amount
        public double CreditAmount
        {
            get
            {
                return _creditAmount;
            }
            set
            {
                _creditAmount = value;
            }
        }

        //Ovveride for abstract tranaction, adds a credit to receivers balance
        public override void transact()
        {
            _reciever.Balance += _creditAmount;
        }

    }
}