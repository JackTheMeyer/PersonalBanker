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
using System.IO;
using BankerLibrary;

namespace PersonalBankerWPF
{
    /// <summary>
    /// Interaction logic for OpenAccount.xaml
    /// </summary>
    public partial class OpenAccount : Page
    {
        public OpenAccount()
        {
            InitializeComponent();
        }

        public void CreateInterest(object sender, RoutedEventArgs e)
        {
            InterestOpenBlock.Visibility = Visibility.Visible;
            InterestOpenBox.Visibility = Visibility.Visible;

            InterestNameBlock.Visibility = Visibility.Visible;
            InterestNameBox.Visibility = Visibility.Visible;

            InterestOpenButton.Visibility = Visibility.Visible;

            if (!Manager.IsTextAllowed(InterestOpenBox.Text))
            {
                InterestOpenBlock.Text = "Please only enter numbers";
            }
        }

        public void OpenInterest(object sender, RoutedEventArgs e)
        {
            Interest intAcc = new Interest("063011", GenerateAccountNumber());
            intAcc.Name += InterestNameBox.Text;
            double bal = double.Parse(InterestOpenBox.Text);
            intAcc.Balance = bal;
            Manager.currentUser.AccountList.Add(intAcc);
            Manager.banker.saveAccounts();

            UserPage userPage = new UserPage();
            this.NavigationService.Navigate(userPage);
        }
        public void CreateSavings(object sender, RoutedEventArgs e)
        {
                SavingsOpenBlock.Visibility = Visibility.Visible;
                SavingsOpenBox.Visibility = Visibility.Visible;

                SavingsNameBlock.Visibility = Visibility.Visible;
                SavingsNameBox.Visibility = Visibility.Visible;

                SavingsOpenButton.Visibility = Visibility.Visible;

                if (!Manager.IsTextAllowed(InterestOpenBox.Text))
                {
                    InterestOpenBlock.Text = "Please only enter numbers";
                }
        }
        public void OpenSavings(object sender, RoutedEventArgs e)
        {
            Savings savAcc = new Savings("063011", GenerateAccountNumber());
            savAcc.Name += SavingsNameBox.Text;
            
            double bal = double.Parse(SavingsOpenBox.Text);
            savAcc.Balance = bal;
            Manager.currentUser.AccountList.Add(savAcc);

            Manager.banker.saveAccounts();

            UserPage userPage = new UserPage();
            this.NavigationService.Navigate(userPage);
        }
  
        public string GenerateAccountNumber()
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\Jackm\Desktop\PBv2\RandomAccountNumbers.txt"))
            {
                int i = 0;
                string line = "";
                while (i < Manager.accountCounter)
                {
                    line = sr.ReadLine();
                    i++;
                }

                Manager.accountCounter++;
                return line;
            }
        }
    }
}
