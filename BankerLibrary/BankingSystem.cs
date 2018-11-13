using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankerLibrary
{
    public class BankingSystem
    {
        // Banksystem ascts as the server for holding user and account data
        // user list of all the users saved in the system
        private List<User> _userList = new List<User>();
        

        public BankingSystem()
        {

        }
        
        //checks to see if there is available funds in recipeient account
        public void verifyTransaction(Transaction transfer)
        {
            if (transfer is Debit)
            {
                Debit tfer = transfer as Debit;
                if (tfer.Reciever.Balance < tfer.DebitAmount)
                {
                    errorMessage("Not enough funds available in account: " + tfer.Reciever.BSB + " " + tfer.Reciever.AccountNumber);
                } else
                {
                    completeTransaction(transfer);
                }
            }

            completeTransaction(transfer);
            
        }
        
        // Populates users and their accounts from a text file
        public void populateAccounts()
        {

            using (StreamReader sr = new StreamReader(@"C:\Users\Jackm\Desktop\PBv2\users.txt"))
            {
                Manager.accountCounter = int.Parse(sr.ReadLine());

                int i = 0;

                while (!sr.EndOfStream)
                {
                    
                    i = 0;
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
        
        // Write all users and their accounts to a text file
        public void saveAccounts()
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Jackm\Desktop\PBv2\users.txt"))
            {
                sw.Write(Manager.accountCounter);
               foreach (User u in _userList)
                {
                    sw.WriteLine();
                    sw.Write(u.Username);
                    sw.WriteLine();
                    sw.Write(u.Password);
                    sw.WriteLine();
                    sw.Write(u.AccountList.Count);
                    foreach (Account a in u.AccountList)
                    {
                        if (a is Interest)
                        {
                            sw.WriteLine();
                            sw.Write("Interest");
                        }
                        else
                        {
                            sw.WriteLine();
                            sw.Write("Savings");
                        }
                        sw.WriteLine();
                        sw.Write(a.Name);
                        sw.WriteLine();
                        sw.Write(a.AccountNumber);
                        sw.WriteLine();
                        sw.Write(a.BSB);
                        sw.WriteLine();
                        sw.Write(a.Balance);
                    }
                }
            }
        } 

        // performs a transaction
        public void completeTransaction(Transaction transfer)
        {
            transfer.transact();
        }

        // string to hold error mesages for database implementation
        public string errorMessage(string error)
        {
            return error;
        }

        // Adds a user to list of uses
        public void AddUser(User user)
        {
            _userList.Add(user);
        }

       
        // Getter fo rlist of users
        public List<User> Users
        {
            get
            {
                return _userList;
            }
        }

        


    }
}