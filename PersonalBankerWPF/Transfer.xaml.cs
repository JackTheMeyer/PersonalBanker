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
    /// <summary>
    /// Interaction logic for Transfer.xaml
    /// </summary>
    public partial class Transfer : Page
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void ViewSendOptions(object sender, RoutedEventArgs e)
        {
            Manager.currentTransfer = new Credit(null, null, 00.00);

            accountTextBlock.Visibility = Visibility.Visible;
            AmountTextBlock.Visibility = Visibility.Visible;
            TransferButton.Visibility = Visibility.Visible;

            accountTextBlock.Text = "What account will you send too?";
            AmountTextBlock.Text = "How much would you like to send?";
            TransferButton.Content = "Send";
        }

        private void ViewTakeOptions(object sender, RoutedEventArgs e)
        {
            Manager.currentTransfer = new Debit(null, null, 00.00);

            accountTextBlock.Visibility = Visibility.Visible;
            AmountTextBlock.Visibility = Visibility.Visible;
            TransferButton.Visibility = Visibility.Visible;

            accountTextBlock.Text = "What account will you debit?";
            AmountTextBlock.Text = "How much would you like to debit?";
            TransferButton.Content = "Process Debit Request";
        }

        private void confirmTransfer(object sender, RoutedEventArgs e)
        {
            string bsb = BSBTextBox.Text;
            string accNo = accountTextBlock.Text;

            Account rcvr = new Savings(bsb, accNo);
            Account sndr = new Savings(Manager.currentUser.ActiveAccount.BSB, Manager.currentUser.ActiveAccount.AccountNumber);
            Double amount = Double.Parse(AmountTextBox.Text);

            Manager.currentTransfer.Sender = sndr;
            Manager.currentTransfer.Reciever = rcvr;
            Manager.currentTransfer.Amount = amount;

            Manager.currentTransfer.transact();
            UserPage userPage = new UserPage();
            this.NavigationService.Navigate(userPage);



        }

        
    }
}
