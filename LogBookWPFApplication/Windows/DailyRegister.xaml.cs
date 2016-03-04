using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
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
using System.Data.SqlClient;
using System.Data;
using LogBookWPFApplication.AppData;
using System.Collections.ObjectModel;
//using LogBookWPFApplication.DailyRegister;

namespace LogBookWPFApplication
{
    /// <summary>
    /// Interaction logic for DailyRegister.xaml
    /// </summary>
    public partial class DailyRegister : Window
    {
        ConnectionsSQL con = new ConnectionsSQL();
        int mentorID = 0;
        public string name;
        public string password;
        public List<attribs> personAttrib;
       
        public List<string> names { get; set; }
        public List<string> names2 { get; set; }
        public List<int> ID = new List<int>();
        public List<int> MenID = new List<int>();


        public DailyRegister()
        {

            names = getNames();
            AttendanceDetail a = new AttendanceDetail();
            List<Person> personList = new List<Person>();

            personAttrib = new List<attribs>()
            {
                new attribs() { }
            };
           
            InitializeComponent();
            dprDate.SelectedDate = DateTime.Now;
            Name.ItemsSource = names;

            cmbMentors.ItemsSource= names2;
            dgrdInformation.ItemsSource = personAttrib;

        }
    
    
        private void cmbMentors_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            using (LogBookApplicationDBEntities db = new LogBookApplicationDBEntities())
            {
                List<Person> mentor = (from x in db.People
                                       where x.RoleID == 2
                                       select x).ToList();
                foreach (var item in mentor)
                {
                    //MenID.Add(item.PersonID);

                    if (cmbMentors.SelectedItem.ToString() == item.Name)
                    {
                        mentorID = item.PersonID;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Activate();
            if (Learner.RoleIdentification == 1)
            {
                main.btnUserControl.IsEnabled = false;
            }
           
            main.Show();
            this.Close();
        }

        private List<string> getNames()
        {
           
            try
            {
                using (LogBookApplicationDBEntities db = new LogBookApplicationDBEntities())
                {
                    List<Person> mentee = (from x in db.People
                                           where x.RoleID == 1
                                           select x).ToList();

                    List<string> names = new List<string>();

                    foreach (var item in mentee)
                    {
                        names.Add(item.Name + " " + item.Surname);
                        ID.Add(item.PersonID);
                    }
                   

                    return names;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }

        private List<string> getNames2()
        {

            try
            {
                using (LogBookApplicationDBEntities db = new LogBookApplicationDBEntities())
                {
                    

                    List<Person> mentor = (from x in db.People
                                           where x.RoleID == 2
                                           select x).ToList();

                    List<string> names = new List<string>();

                   
                    foreach (var item in mentor)
                    {
                        names.Add(item.Name);
                        MenID.Add(item.PersonID);
                    }

                    return names;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }



        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();


            int menteeID = Name.DisplayIndex + 1;

            try
            {
        
                List<string> n = new List<string>();
               
                var master = new AttendanceMaster();
                var attDetail = new AttendanceDetail();
                var person = new Person();
                
               
                using (var dbSave = new LogBookApplicationDBEntities())
                {

                    master.Date = dprDate.SelectedDate.Value;
                    master.TrainedIn = txtComments.Text;
                    dbSave.AttendanceMasters.Add(master);
                    dbSave.SaveChanges();
                   // n = getNames();

                    //List<AttendanceMaster> a = (from x in dbSave.AttendanceMasters
                    //                            where x.Date == dprDate.SelectedDate
                    //                            select x).ToList();

                    foreach (var iii in personAttrib)
                    {
                       
                        attDetail.Hours = iii.Hours;
                        
                        attDetail.MasterID = master.MasterID;

                        attDetail.MentorID = mentorID;

                        attDetail.MenteeID = menteeID;
                        
                        dbSave.AttendanceDetails.Add(attDetail);
                        dbSave.SaveChanges();
                    }
                   
                    dbSave.AttendanceDetails.Add(attDetail);
                    dbSave.SaveChanges();
                }
              
                              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dprDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            
            using (LogBookApplicationDBEntities db = new LogBookApplicationDBEntities())
                {
                    List<AttendanceMaster> mentor = (from x in db.AttendanceMasters
                                                     join y in db.AttendanceDetails
                                                     on x.MasterID equals y.MasterID 
                                                     join z in db.People on y.MenteeID equals z.PersonID 
                                           where x.Date.ToString() == dprDate.SelectedDate.ToString()
                                           select x).ToList();
                    foreach (var item in mentor)
                    {
                        dgrdInformation.ItemsSource = mentor;
                    }
                }
            
           // BindMyData();
        }

        private void dgrdInformation_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            dgrdInformation.CanUserAddRows = true;
            

        }
    }
}

