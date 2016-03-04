using LogBookWPFApplication.AppData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace LogBookWPFApplication
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public int id = 0; 
        static SqlConnection thisConnection = new SqlConnection(@"Server=DVT-LMABOHO\SQL2012;Database=LogBookApplicationDB;Trusted_Connection=Yes;");
        SqlCommand comm = new SqlCommand("", thisConnection);
        public LoginPage()
        {
            InitializeComponent();
            string name = txtUserName.Text;
            string password = txtPassword.Password;
        }
        DailyRegister d = new DailyRegister();

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUserName.Text != null && txtPassword.Password != null)
            {
                ConnectionsSQL myConnect = new ConnectionsSQL();
                User user = ConnectionsSQL.LoginUser(txtUserName.Text, Convert.ToString(txtPassword.Password));
                //     User u = new User();
                try
                {
                 //   string name;
                    MainWindow main = null;  
                    if (user.Email != null && user.Password != null && user != null)
                    {
                       
                            Learner.RoleIdentification = user.RoleID;
                            Learner.Email = txtUserName.Text;
                            main = new MainWindow();
                           // Learner.UserID = user.Id;
                            this.Hide();
                            main.Show();


                        if (user.RoleID == 1)
                        {

                            main.btnUserControl.IsEnabled = false;
                            main.btnMonthlyEvaluation.IsEnabled = false;
                            main.btnWeeklyLogbook.IsEnabled = true;

                        }
                        else
                        {

                            main.btnUserControl.IsEnabled = true;
                            main.btnMonthlyEvaluation.IsEnabled = false;
                            main.btnWeeklyLogbook.IsEnabled = true;

                        }

                    }
                    else
                    {
                        MessageBox.Show("Error Logging in, Please check your user name and password");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Please enter your correct user name and password");
                }
            }
            else
            {
                MessageBox.Show("Please make sure you have entered all your credentials");
            }
            
          
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
