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
    /// Interaction logic for PersonalBankerHome.xaml
    /// </summary>
    public partial class PersonalBankerHome : Page
    {
        private User bankManager = new User("BankManager", "Admin");
        public PersonalBankerHome()
        {
            InitializeComponent();
        }

        public void CreateUser(object sender, RoutedEventArgs e)
        {
            NewUser newUser = new NewUser();
            this.NavigationService.Navigate(newUser);
        }

        public void LoginUser(object sender, RoutedEventArgs e)
        {
            PasswordTextBox.Text = PasswordBox.Password;

            foreach (User u in Manager.banker.Users)
            {
                if (UsernameTextBox.Text == u.Username && PasswordTextBox.Text == u.Password)
                {
                    Manager.currentUser = u;
                    UserPage userPage = new UserPage();
                    this.NavigationService.Navigate(userPage);
                    
                    break;
                }
                else
                {
                    ErrorTextBlock.Visibility = Visibility.Visible;
                }
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
