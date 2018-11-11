using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PersonalBankerWPF
{
    public class BankingSystem
    {
        private List<User> _userList = new List<User>();
        private string _nextBSB = "";
        private string _nextAccNo = "";

        public BankingSystem()
        {

        }
        
        public void verifyTransaction(Transaction transfer)
        {
            if (transfer is Debit)
            {
                Debit tfer = transfer as Debit;
                if (tfer.Reciever.Balance < tfer.Amount)
                {
                    errorMessage("Not enough funds available in account: " + tfer.Reciever.BSB + " " + tfer.Reciever.AccountNumber);
                } else
                {
                    completeTransaction(transfer);
                }
            }

            completeTransaction(transfer);
            
        }
        
        public void populateAccounts()
        {

            using (StreamReader sr = new StreamReader(@"C:\Users\Jack\Desktop\OOP\PersonalBankerWPF\users.txt"))
            {
                Manager.accountCounter = int.Parse(sr.ReadLine());

                int i = 0;
                
                while (!sr.EndOfStream)
                {
                    string username = sr.ReadLine();
                    string password = sr.ReadLine();
                    int accountList = int.Parse(sr.ReadLine());

                    User user = new User(username, password);

                    while (i < accountList)
                    {
                        string type = sr.ReadLine();
                        string name = sr.ReadLine();
                        string accNumber = sr.ReadLine();
                        string BSB = sr.ReadLine();
                        double balance = Double.Parse(sr.ReadLine());

                        if (type == "Interest")
                        {
                            Interest acc = new Interest(BSB, accNumber);
                            acc.Name = name;
                            acc.Balance = balance;
                            user.AccountList.Add(acc);
                        }
                        else
                        {
                            Savings acc = new Savings(BSB, accNumber);
                            acc.Name = name;
                            acc.Balance = balance;
                            user.AccountList.Add(acc);
                        }

                        i++;
                        
                    }

                    Manager.banker.Users.Add(user);
                    
                    
                }

            }


        }
        
        public void saveAccounts()
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Jack\Desktop\OOP\PersonalBankerWPF\users.txt"))
            {
                sw.WriteLine(Manager.accountCounter);
               foreach (User u in _userList)
                {
                    sw.WriteLine(u.Username);
                    sw.WriteLine(u.Password);
                    sw.WriteLine(u.AccountList.Count);
                    foreach (Account a in u.AccountList)
                    {
                        if (a is Interest)
                        {
                            sw.WriteLine("Interest");
                        }
                        else
                        {
                            sw.WriteLine("Savings");
                        }
                        sw.WriteLine(a.Name);
                        sw.WriteLine(a.AccountNumber);
                        sw.WriteLine(a.BSB);
                        sw.WriteLine(a.Balance);
                    }
                }
            }
        } 

        public void completeTransaction(Transaction transfer)
        {
            transfer.transact();
        }

        public string errorMessage(string error)
        {
            return error;
        }

        public void AddUser(User user)
        {
            _userList.Add(user);
        }

        public void AccCreated()
        {
            _nextBSB += 1;
            _nextAccNo += 1;
        }
        public List<User> Users
        {
            get
            {
                return _userList;
            }
        }

        public string BSB
        {
            get
            {
                return _nextBSB;
            }
        }

        public string Acc
        {
            get
            {
                return _nextAccNo;
            }
        }


    }
}