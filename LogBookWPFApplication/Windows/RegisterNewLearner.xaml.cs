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
    /// Interaction logic for RegisterNewLearner.xaml
    /// </summary>
    public partial class RegisterNewLearner : Window
    {
        SqlConnection thisConnection = new SqlConnection(@"Server=DVT-LMABOHO\SQL2012;Database=LogBookApplicationDB;Trusted_Connection=Yes;");
        SqlCommand comm = null;
        public RegisterNewLearner()
        {
            InitializeComponent();
            

        }

        public void BindMyData()
        {
            try
            {
                thisConnection.Open();
                comm = new SqlCommand("SELECT PersonID, Name, Surname, EmailAddress, Password, Role.RoleDiscription AS Role FROM Person, Role WHERE Person.RoleID = Role.RoleID", thisConnection);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(ds);
                dgrdAllInfo.ItemsSource = ds.Tables[0].DefaultView;
                //using (LogBookApplicationDBEntities db = new LogBookApplicationDBEntities())
                //{
                //    List<Person> pp = (from x in db.People
                //                       join y in db.Roles on x.RoleID equals y.RoleID
                //                       where x.RoleID == y.RoleID
                //                       select x).ToList();
                //    List<string> info = new List<string>();
                //    foreach (var item in pp)
                //    {
                //        info.Add(pp.ToString());
                //        info.Remove(item.RoleID.ToString());
                //    }
                //    dgrdAllInfo.ItemsSource = info;
                //}


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                thisConnection.Close();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           

            BindMyData();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                thisConnection.Open();
                comm = new SqlCommand(string.Format("UPDATE Person SET Name='{0}', Surname='{1}', EmailAddress='{2}', Password='{3}', RoleID='{4}' WHERE PersonID='{5}'", txtName.Text, txtSurname.Text, txtEmail.Text, txtPassword.Text, txtRole.Text, Learner.UserID), thisConnection);
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a student from the table and update details in the edit section along side.");
            }
            finally
            {
                thisConnection.Close();
                BindMyData();
                txtEmail.Clear();
                txtName.Clear();
                txtPassword.Clear();
                txtRole.Clear();
                txtSurname.Clear();
            }

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtSurname.Text) ||  String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtRole.Text))
            {
                MessageBox.Show("Please make sure you have filled every field."); 
            }
            else
            {

              
            try
            {
                thisConnection.Open();
                 comm = new SqlCommand(string.Format("INSERT INTO Person VALUES('{0}','{1}','{2}','{3}','{4}')", txtName.Text, txtSurname.Text, txtEmail.Text, txtPassword.Text, txtRole.Text), thisConnection);
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The student was not added, please check that the details are correct and try again.");
            }
            finally
            {
                thisConnection.Close();
                BindMyData();
                txtEmail.Clear();
                txtName.Clear();
                txtPassword.Clear();
                txtRole.Clear();
                txtSurname.Clear();
            }
            }

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {

                try
                {

                    thisConnection.Open();
                    comm = new SqlCommand("DELETE FROM Person WHERE PersonID=" + Learner.UserID + "", thisConnection);
                    comm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please select a student whose information you wish to delete from the table.");
                }
                finally
                {
                    thisConnection.Close();
                    BindMyData();
                    txtEmail.Clear();
                    txtName.Clear();
                    txtPassword.Clear();
                    txtRole.Clear();
                    txtSurname.Clear();
                }
            }

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
             MainWindow main = new MainWindow();
            main.Activate();
            main.Show();
            this.Close();
        }

        private void dgrdAllInfo_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

           
            
        }
    }

}