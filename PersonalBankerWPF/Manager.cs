using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PersonalBankerWPF
{
    public static class Manager
    {
        public static User currentUser = null;
        public static BankingSystem banker = new BankingSystem();
        public static Transaction currentTransfer = null;
        public static int accountCounter = 1;


        private static readonly Regex _regex = new Regex("[^0-9.-]+");
        static Manager()
        {
            
        }

        public static bool IsTextAllowed(string text)
        {
           return !_regex.IsMatch(text);
        }
    }
}
