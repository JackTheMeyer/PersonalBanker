using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBankerWPF
{
    public class Credit : Transaction
    {
        private double _creditAmount;

        public Credit(Account sender, Account reciever, double amount) : base(sender, reciever)
        {

        }

        public override void transact()
        {
            Sender.Balance += _creditAmount;
        }

    }
}