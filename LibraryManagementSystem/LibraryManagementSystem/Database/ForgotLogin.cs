using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Database
{
   public class ForgotLogin
    {
        public SqlDataReader getForgotPassword
            (String query)
        {
            try
            {
                //step1: connection string
                string myNwConnectionstring = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.NwConnString"].ConnectionString;


                SqlConnection myNwConnection = new System.Data.SqlClient.SqlConnection(myNwConnectionstring);

                myNwConnection.Open();


                //step 5: Adapter
                SqlCommand cmd = new SqlCommand(query, myNwConnection);
                SqlDataReader reader = cmd.ExecuteReader();


                return reader;
            }
            catch (Exception) { return null; }
        }
    }
}
