using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBankerWPF
{
    public abstract class Transaction
    {
        private Account _sender;
        private Account _reciever;
        private double _amount;

        public Transaction(Account sender, Account reciever)
        {
            _sender = sender;
            _reciever = reciever;
        }

        public abstract void transact();

        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
        public Account Sender
        {
            get
            {
                return _sender;
            }
            set
            {
                _sender = value;
            }
        }

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
