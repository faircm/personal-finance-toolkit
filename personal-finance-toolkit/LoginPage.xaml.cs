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

namespace personal_finance_toolkit
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public string? Username { get; set; }
        public string? Password { get; set; }

        private string testUsername = "test";
        private string testPassword = "test";

        public LoginPage()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (usernameBox.Text == testUsername && passwordBox.Password == testPassword)
            {
                MessageBox.Show("Login successful");
                NavigationService?.Navigate(new MainPage());
            }
            else
            {
                // Authentication failed
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
