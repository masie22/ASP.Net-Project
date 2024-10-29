using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Database
{
    public class LoginDatabase
    {
        SqlConnection myNwConnection;
        string myNwConnectionstring = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.NwConnString"].ConnectionString;
        public SqlDataReader Getdata(String query)   
        {

            SqlConnection myNwConnection = new SqlConnection(myNwConnectionstring);

            SqlCommand cmd = new SqlCommand(query, myNwConnection);//this sql command is running on this connection i.e myNwConnection

            try
            {
              myNwConnection.Open();

                //Step 3: Execute the sql command and store the data in sql datareader
                               
                SqlDataReader reader = cmd.ExecuteReader();

                return reader;
            }
            catch (Exception ex)
            { 
                return null;
            }
            finally
            {
                cmd.Dispose();
            }
        }//end try/catch

        public int ProcessData(string query)
        {
            try
            {

                 myNwConnection = new SqlConnection(myNwConnectionstring);

                myNwConnection.Open();

                //Step 3: Execute the sql command and store the data in sql datareader

                SqlCommand cmd = new SqlCommand(query, myNwConnection);//this sql command is running on this connection i.e myNwConnection

                return cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                return -1;
            }
        }

        public void ConnectionClose()
        {
            myNwConnection.Close();
        }

    }//end class
}//end namespace
