using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersonalBankerWPF
{
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
            populateAccounts();
        }

        public void MakeTransfer(object sender, RoutedEventArgs e)
        {
            Button account = sender as Button;
            switch (account.Name)
            {
                case "Account1":
                    Manager.currentUser.ActiveAccount = Manager.currentUser.AccountList[0];
                    break;
                case "Account2":
                    Manager.currentUser.ActiveAccount = Manager.currentUser.AccountList[1];
                    break;
                case "Account3":
                    Manager.currentUser.ActiveAccount = Manager.currentUser.AccountList[2];
                    break;
                case "Account4":
                    Manager.currentUser.ActiveAccount = Manager.currentUser.AccountList[3];
                    break;
                case "Account5":
                    Manager.currentUser.ActiveAccount = Manager.currentUser.AccountList[4];
                    break;
                default:
                    break;
            }
            Transfer tfer = new Transfer();
            this.NavigationService.Navigate(tfer);
        }

        public void populateAccounts()
        {
            int length = 0;
            foreach (Account a in Manager.currentUser.AccountList)
            {
                length++;
            }

            for (int i = 0; i<length; i++)
            {
                TextBlock txtName = new TextBlock();
                TextBlock txtBal = new TextBlock();
                TextBlock txtBSB = new TextBlock();
                TextBlock txtAcc = new TextBlock();
                Account a = null;
                try
                {
                     a = Manager.currentUser.AccountList[i];
                }
                catch { }

                switch (i)
                {
                    case 0:
                        nameText1.Text = a.Name;
                        balanceText1.Text = a.Balance.ToString();
                        numberText1.Text = (a.BSB.ToString() + " " + a.AccountNumber.ToString());

                        Account1.Visibility = Visibility.Visible;
                        break;
                    case 1:
                        nameText2.Text = a.Name;
                        balanceText2.Text = a.Balance.ToString();
                        numberText2.Text = (a.BSB.ToString() + " " + a.AccountNumber.ToString());

                        Account2.Visibility = Visibility.Visible;
                        break;
                    case 2:
                        nameText3.Text = a.Name;
                        balanceText3.Text = a.Balance.ToString();
                        numberText3.Text = (a.BSB.ToString() + " " + a.AccountNumber.ToString());

                        Account3.Visibility = Visibility.Visible;
                        break;
                    case 3:
                        nameText4.Text = a.Name;
                        balanceText4.Text = a.Balance.ToString();
                        numberText4.Text = (a.BSB.ToString() + " " + a.AccountNumber.ToString());

                        Account4.Visibility = Visibility.Visible;
                        break;
                    case 4:
                        nameText5.Text = a.Name;
                        balanceText5.Text = a.Balance.ToString();
                        numberText5.Text = (a.BSB.ToString() + " " + a.AccountNumber.ToString());

                        Account5.Visibility = Visibility.Visible;
                        break;
                    default:     
                        break;
                }   
            }
            
        }

        public void CreateNewAccount(object sender, RoutedEventArgs e)
        {
            OpenAccount openAccount = new OpenAccount();
            this.NavigationService.Navigate(openAccount);
        }
    }
}
