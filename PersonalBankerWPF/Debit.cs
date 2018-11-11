using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBankerWPF
{
    public class Debit : Transaction
    {
        private double _debitAmount;


        public Debit(Account sender, Account reciever, double amount) : base(sender, reciever)
        {
            _debitAmount = amount;
        }

        public override void transact()
        {
            Sender.Balance -= _debitAmount;
        }

        public Double Amount
        {
            get
            {
                return _debitAmount;
            }
        }
    }
}
