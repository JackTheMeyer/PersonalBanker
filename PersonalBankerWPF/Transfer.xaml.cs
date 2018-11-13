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
using BankerLibrary;

namespace PersonalBankerWPF
{
    /// <summary>
    /// Interaction logic for Transfer.xaml
    /// </summary>
    public partial class Transfer : Page
    {
        public Transfer()
        {
            InitializeComponent();
            balanceText.Text = Manager.currentUser.ActiveAccount.Balance.ToString();
            numberText.Text = Manager.currentUser.ActiveAccount.AccountNumber;
            nameText.Text = Manager.currentUser.ActiveAccount.Name;

        }

        private void ViewSendOptions(object sender, RoutedEventArgs e)
        {
            Manager.currentTransfer = new Credit(null, 00.00);

            accountTextBlock.Visibility = Visibility.Visible;
            BSBTextBox.Visibility = Visibility.Visible;
            AccountTextBox.Visibility = Visibility.Visible;
            AmountTextBlock.Visibility = Visibility.Visible;
            AmountTextBox.Visibility = Visibility.Visible;
            DescriptionTextBlock.Visibility = Visibility.Visible;
            DescriptionTextBox.Visibility = Visibility.Visible;
            TransferButton.Visibility = Visibility.Visible;

            accountTextBlock.Text = "What account will you send too?";
            AmountTextBlock.Text = "How much would you like to send?";
            TransferButton.Content = "Send";
        }

        private void ViewTakeOptions(object sender, RoutedEventArgs e)
        {
            Manager.currentTransfer = new Debit(null, 00.00);

            accountTextBlock.Visibility = Visibility.Visible;
            BSBTextBox.Visibility = Visibility.Visible;
            AccountTextBox.Visibility = Visibility.Visible;
            AmountTextBlock.Visibility = Visibility.Visible;
            AmountTextBox.Visibility = Visibility.Visible;
            DescriptionTextBlock.Visibility = Visibility.Visible;
            DescriptionTextBox.Visibility = Visibility.Visible;
            TransferButton.Visibility = Visibility.Visible;

            accountTextBlock.Text = "What account will you debit?";
            AmountTextBlock.Text = "How much would you like to debit?";
            TransferButton.Content = "Process Debit Request";
        }

        public bool validateRules(Account sndr, Account rcvr)
        {
            if (sndr is Interest)
            {
               foreach(Account a in Manager.currentUser.AccountList)
                {
                    if (rcvr == a)
                    {
                        return true;
                    }
                }

                return false;

            }
            else
            {
                return true;
            }
        }

        private Account validateReciever(string bsb, string accNo)
        {
            foreach (User u in Manager.banker.Users)
            {
                foreach (Account a in u.AccountList)
                {
                    if (bsb == a.BSB && accNo == a.AccountNumber)
                    {
                        if (a is Interest)
                        {
                            return a as Interest;
                        }
                        else
                        {
                            return a as Savings;
                        }

                    }
                }
            }
            return null;
        }

        private void confirmTransfer(object sender, RoutedEventArgs e)
        {
            string bsb = BSBTextBox.Text;
            string accNo = AccountTextBox.Text;
            Account rcvr = (validateReciever(bsb, accNo));

            Account sndr = Manager.currentUser.ActiveAccount;
            Double amount = Double.Parse(AmountTextBox.Text);

            if (rcvr == null)
             {
                ErrorTextBlock.Text = "That account does not exist, please try again";
                ErrorTextBlock.Visibility = Visibility.Visible;
                return;
             }
            if (!validateRules(sndr, rcvr))
            {
                ErrorTextBlock.Text = "You can only transfer from your Interest Accounts to your savings accounts.";
                ErrorTextBlock.Visibility = Visibility.Visible;
                return;
            }
            
            
            if (Manager.currentTransfer is Credit)
            {
                if (rcvr.Balance < amount)
                {
                    ErrorTextBlock.Text = "You dont have enough funds to complete that transaction";
                    ErrorTextBlock.Visibility = Visibility.Visible;
                    return;
                }

                Credit credit = new Credit(rcvr, amount);
                Debit debit = new Debit(sndr, amount);
                debit.transact();
                credit.transact();
            }
            else
            {
                if (rcvr.Balance < amount)
                {
                    ErrorTextBlock.Text = "Debit declined. Insufficient funds on recipient account.";
                    ErrorTextBlock.Visibility = Visibility.Visible;
                    return;

                }
                Debit debit = new Debit(rcvr, amount);
                Credit credit = new Credit(sndr, amount);
                debit.transact();
                credit.transact();
            }

            Manager.banker.saveAccounts();
            UserPage userPage = new UserPage();
            this.NavigationService.Navigate(userPage);



        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            UserPage userpage = new UserPage();
            this.NavigationService.Navigate(userpage);
        }
    }
}
