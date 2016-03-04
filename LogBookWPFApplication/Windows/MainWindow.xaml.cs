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

namespace LogBookWPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // private string name;
        public MainWindow()
        {
            InitializeComponent();
            btnUserControl.IsEnabled = true;
            btnMonthlyEvaluation.IsEnabled = false;
            btnWeeklyLogbook.IsEnabled = true;
            lblDisplay.Content = "Signed in as: " + Learner.Email;
            
        }
       // LogBookAppDBEntities db = new LogBookAppDBEntities();
        private void btnDailyRegister_Click(object sender, RoutedEventArgs e)
        {
            DailyRegister dr = new DailyRegister();
            dr.Show();
            this.Hide();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
            // 

        }

        private void btnUserControl_Click(object sender, RoutedEventArgs e)
        {
            RegisterNewLearner reg = new RegisterNewLearner();
            reg.Show();
            this.Hide();

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnWeeklyLogbook_Click(object sender, RoutedEventArgs e)
        {
            WeeklyLogbook week = new WeeklyLogbook();
            week.Activate();
            if (Learner.RoleIdentification == 2)
            {
                week.btnCreateNewLogbook.IsEnabled = false;
            }

            week.Show();
            this.Hide();
        }
    }
}
