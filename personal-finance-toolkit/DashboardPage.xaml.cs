using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
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
    /// Interaction logic for DashboardPage.xaml
    /// </summary>
    public partial class DashboardPage : Page
    {
        public ObservableCollection<PieChartData> PieChartDataCollection { get; set; } =
            new ObservableCollection<PieChartData>();

        public DashboardPage(string userId, string username)
        {
            InitializeComponent();
            LoadChartData();
            int hour = DateTime.Now.ToLocalTime().Hour;
            if (hour < 12)
            {
                welcomeText.Text = $"Good Morning, {username}";
            }
            else if (hour < 18)
            {
                welcomeText.Text = $"Good afternoon, {username}";
            }
            else
            {
                welcomeText.Text = $"Good evening, {username}";
            }
        }

        private void LoadChartData()
        {
            PieChartDataCollection = new ObservableCollection<PieChartData>
            {
                new PieChartData { Category = "Rent", Value = 1200 },
                new PieChartData { Category = "Utilities", Value = 300 },
                new PieChartData { Category = "Transportation", Value = 150 },
                new PieChartData { Category = "Entertainment", Value = 400 },
                new PieChartData { Category = "Groceries", Value = 250 },
                new PieChartData { Category = "Dining Out", Value = 100 },
            };

            ((PieSeries)summaryChart.Series[0]).ItemsSource = PieChartDataCollection;
        }

        public class PieChartData
        {
            public required string Category { get; set; }
            public float Value { get; set; }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) { }

        private void ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Change Password Page
            //NavigationService?.Navigate(new ChangePasswordPage());
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Login Page
            // TODO: Include logic to clear user session
            NavigationService?.Navigate(new LoginPage());
        }
    }
}
