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

    class Connections
    {
        SqlConnection thisConnection = new SqlConnection(@"Server=DVT-LMABOHO\SQL2012;Database=LogBookAppDB;Trusted_Connection=Yes;");

        public void BindMyData()
        {
            try
            {
                thisConnection.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM Student", thisConnection);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(ds);
                dgrdAllInfo.ItemsSource = ds.Tables[0].DefaultView;
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

        public void Update()
        {
            try
            {
                thisConnection.Open();
                SqlCommand comm = new SqlCommand("UPDATE Student SET StudName='" + txtStudName.Text + "',StudResult=" + txtStudResult.Text + "WHERE StudId=" + txtStudId.Text + "", thisConnection);
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                thisConnection.Close();
                BindMyData();
            }
        }

        public void Add()
        {
            try
            {
                thisConnection.Open();
                SqlCommand comm = new SqlCommand(string.Format("INSERT INTO Person VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", txtName.Text, txtSurname.Text, txtID.Text, txtEmail.Text, txtPassword.Text, txtContactNo.Text, Convert.ToInt32(txtRoleID.Text)), thisConnection);
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                thisConnection.Close();
                BindMyData();
            }
        }


        public void Delete()
        {
            try
            {
                thisConnection.Open();
                SqlCommand comm = new SqlCommand("DELETE FROM Person WHERE IDNr=" + txtID.Text + "", thisConnection);
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                thisConnection.Close();
                BindMyData();
            }
        }
         
    }
}
