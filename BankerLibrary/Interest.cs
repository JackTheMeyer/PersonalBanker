using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerLibrary
{
    public class Interest : Account
    {
        //holds values for balance interest
        private double _balance;
        private double _interest;

        public Interest(string bsb, string account) : base(bsb, account)
        {
            
        }

        // getter for Balance
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

        // placeholder for database implementation
        public void recieveTransaction()
        {

        }

        // upcoming feature to alter interest
        public void gainInterest()
        {
            _interest += (_balance * 0.01);
        }

        public void lostInterest()
        {
            _interest = 0;
        }
    }
}
