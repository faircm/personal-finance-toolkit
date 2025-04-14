using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isAuthenticated = false;

        public MainWindow()
        {
            InitializeComponent();
            if (!isAuthenticated)
            {
                mainFrame.Navigate(new LoginPage());
            }
            else
            {
                mainFrame.Navigate(new DashboardPage("userId", "username"));
            }
        }
    }
}
