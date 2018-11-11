using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBankerWPF
{
    public class Savings : Account
    {
        private double _balance;

        public Savings(string bsb, string account) : base(bsb, account)
        {
            
        }

        public override double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        public void recieveTransaction()
        {

        }



    }
}
