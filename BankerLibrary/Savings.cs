using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerLibrary
{
    public class Savings : Account
    {
        // holds value for balance
        private double _balance;

        public Savings(string bsb, string account) : base(bsb, account)
        {
            
        }

        // override  for balance
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


        // feature for upcoming database intergration
        public void recieveTransaction()
        {

        }



    }
}
