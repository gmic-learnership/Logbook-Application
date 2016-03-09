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
        
        public string name;
        public string password;
        public List<attribs> personAttrib;
       
        public List<string> names { get; set; }
        public List<string> names2 { get; set; }
        public List<int> ID = new List<int>();
        public List<int> MenID = new List<int>();
        List<attribs> persons;


        public DailyRegister()
        {

            names = getNames();
            AttendanceDetail a = new AttendanceDetail();
            List<Person> personList = new List<Person>();

            personAttrib = new List<attribs>()
            {
               // new attribs() { }
            };
           
            InitializeComponent();
            dprDate.SelectedDate = DateTime.Now;
            Name.ItemsSource = names;

            names2 = getNames2();
            cmbMentors.ItemsSource = names2;
            dgrdInformation.ItemsSource = personAttrib;

            getInfo();

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


            try
            {

                List<string> n = new List<string>();

                var master = new AttendanceMaster();
                var attDetail = new AttendanceDetail();
                var person = new Person();
               

                using (var dbSave = new LogBookApplicationDBEntities())
                {
                    if (cmbMentors.SelectedIndex < 0 || txtComments.Text == "")
                    {
                        MessageBox.Show("Please make sure you have provided all details");
                    }
                    else
                    {

                            if (master.Date != dprDate.SelectedDate)
                            {
                                btnSave.IsEnabled = true;
                                master.Date = dprDate.SelectedDate.Value;
                                master.TrainedIn = txtComments.Text;
                                dbSave.AttendanceMasters.Add(master);
                                dbSave.SaveChanges();
                            }

                                int index = 0;
                                foreach (var iii in persons)
                                {

                                    DataGridCell c = DataGridHelper.GetCell(dgrdInformation, index, 0);
                                    ComboBox c1 = (ComboBox)c.Content;
                                   // MessageBox.Show(c1.Text.ToString());

                                    attDetail.Hours = iii.Hours;
                                    attDetail.MasterID = master.MasterID;

                                    attDetail.MentorID = MenID.ElementAt(cmbMentors.SelectedIndex);

                                    attDetail.MenteeID = ID.ElementAt(c1.SelectedIndex);

                                    dbSave.AttendanceDetails.Add(attDetail);
                                    dbSave.SaveChanges();
                                    index++;
                                }

                            for (int i = 0; i < dgrdInformation.SelectedIndex; i++)
                            {
                            
                              
                            }
                            MessageBox.Show("Information successfully saved");
                        }

                    
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please make sure you have provided all details");
            }
        
        }

        private void dprDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

            getInfo();
            
        }

        void getInfo()
        {
            List<string> selectedNames = new List<string>();
            persons = new List<attribs>();

            using (LogBookApplicationDBEntities db = new LogBookApplicationDBEntities())
            {
                List<AttendanceDetail> learnerDetails = (from x in db.AttendanceDetails
                                                         join y in db.AttendanceMasters on x.MasterID equals y.MasterID
                                                         //join z in db.People on y.MenteeID equals z.PersonID 
                                                         where y.Date == dprDate.SelectedDate
                                                         select x).ToList();



                List<AttendanceMaster> mm = (from v in db.AttendanceMasters
                                             where v.Date == dprDate.SelectedDate
                                             select v).ToList();
                //  List<int> hours = new List<int>();

                List<attribs> a = new List<attribs>()
                { };

                foreach (var item in learnerDetails)
                {


                    foreach (var i in ID)
                    {
                        foreach (var comm in mm)
                        {
                            txtComments.Text = comm.TrainedIn;
                            if (dprDate.SelectedDate != comm.Date)
                            {
                                cmbMentors.SelectedIndex = 0;
                                txtComments.Text = "";
                            }
                        }

                        if (i.Equals(item.MenteeID))
                        {

                            //   hours.Add(item.Hours);
                            selectedNames.Add(names.ElementAt(ID.IndexOf(item.MenteeID)));
                            cmbMentors.SelectedIndex = MenID.IndexOf(item.MentorID);
                        }

                    }
                }

                    for (int i = 0; i < learnerDetails.Count;i++)
                    {

                        int id = learnerDetails[i].MenteeID;
                        List<Person> mentee = (from x in db.People
                                               where x.PersonID == id
                                               select x).ToList();

                        persons.Add(new attribs(mentee[0].Name + " " + mentee[0].Surname, learnerDetails[i].Hours));
                    }

                    dgrdInformation.ItemsSource = persons;
                dgrdInformation.SelectedIndex = 0;

                }
        }

        private void dgrdInformation_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
        }

        private void dgrdInformation_CurrentCellChanged(object sender, EventArgs e)
        {

            //DataGridCell c = DataGridHelper.GetCell(dgrdInformation, dgrdInformation.SelectedIndex, 1);
            //TextBlock c1 = (TextBlock)c.Content;

            //try
            //{
            //    if (int.Parse(c1.Text) >= 25)
            //    {
            //        MessageBox.Show("Please enter a value less than 24");
            //        c1.Text = "0";
            //        c1.Focus();

            //    }
            //}
            //catch(Exception)
            //{
            //    MessageBox.Show("Please enter a value less than 24");
            //}
           
        }
    }
}

