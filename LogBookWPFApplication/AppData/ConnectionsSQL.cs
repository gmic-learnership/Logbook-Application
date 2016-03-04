using LogBookWPFApplication.AppData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LogBookWPFApplication
{
    class ConnectionsSQL
    {
        private static SqlCommand comm;
       
        private static SqlConnection thisConnection = new SqlConnection(@"Server=DVT-LMABOHO\SQL2012;Database=LogBookApplicationDB;Trusted_Connection=Yes;");

        public  ConnectionsSQL()
        {
            
            //connect = new SqlConnection(connectString);
            comm = new SqlCommand("", thisConnection);
        }

        public static User LoginUser(string email, string password)
        {
            string query = string.Format("SELECT COUNT(*) FROM Person WHERE EmailAddress = '{0}'", email);
            if (!comm.Equals(null))
            {
                comm.CommandText = query;
            }
            try
            {
                thisConnection.Open();
                int amountOfUsers = (int)comm.ExecuteScalar();
                DataTable dt = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter(comm);
                if (amountOfUsers == 1)
                {
                    User user = null;
                    //user exist, check if the passwords match
                    query = string.Format("SELECT Password, PersonID FROM Person WHERE EmailAddress = '{0}'", email);
                    comm.CommandText = query;
                    string dbPassword = comm.ExecuteScalar().ToString();

                    if (dbPassword == password)
                    {

                        using (LogBookApplicationDBEntities db = new LogBookApplicationDBEntities())
                        {
                            List<Person> learner = (from x in db.People
                                                    select x).ToList();
                            
                            foreach (var item in learner)
                            {
                               
                                user = new User(item.PersonID, item.Name, item.Surname, item.EmailAddress, item.Password, item.RoleID);

                            }

                            ad.Fill(dt);
                            Learner.UserID = Convert.ToInt32(dt.AsDataView()[0][1].ToString());
                            // Learner.Email = dt.AsDataView()[0][0].ToString();
                        }

                        return user;
                    }
                    else
                    {
                        //password does not match

                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
           
            finally
            {

                thisConnection.Close();
            }
       }

    }
}
