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
    /// Interaction logic for NewUser.xaml
    /// </summary>
    public partial class NewUser : Page
    {

        public NewUser()
        {
            InitializeComponent();
        }

        private void createUserButton(object sender, RoutedEventArgs e)
        {
            // Create user from New User page field
            User user = new User(UsernameTextBox.Text, PasswordTextBox.Text);

            Manager.banker.AddUser(user);

            Manager.banker.saveAccounts();

            //back to home
            PersonalBankerHome pbHome = new PersonalBankerHome();
            this.NavigationService.Navigate(pbHome);
        }
    }
}
