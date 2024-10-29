using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Database
{
    class AddUserClass
    {
        SqlConnection myNwConnection;   //Global variable
        public SqlDataReader GetUserData(string query) 
        {
            try
            {
                //step1: connection string
                string myNwConnectionstring = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.NwConnString"].ConnectionString;


                 myNwConnection = new SqlConnection(myNwConnectionstring);

                myNwConnection.Open();


               
                SqlCommand cmd = new SqlCommand(query, myNwConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                

                return reader;
            }
            catch (Exception) { return null; }
        }

        public int ProcessUserData(string query)
        {
            try
            {
                //step1: connection string
                string myNwConnectionstring = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.NwConnString"].ConnectionString;


                 myNwConnection = new SqlConnection(myNwConnectionstring);

                myNwConnection.Open();


                //step 5: Adapter
                SqlCommand cmd = new SqlCommand(query, myNwConnection);
              


                return cmd.ExecuteNonQuery();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                return 0; }
        }


        public DataTable GetAllUserData()
        {
            try
            {
                //step1: connection string
                string myNwConnectionstring = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.NwConnString"].ConnectionString;


                myNwConnection = new SqlConnection(myNwConnectionstring);

                myNwConnection.Open();

                //step 5: Adapter
                SqlDataAdapter mynwDataAdapter = new SqlDataAdapter("select * from UserTable", myNwConnection);

                DataSet set = new DataSet();

                mynwDataAdapter.Fill(set);


                return set.Tables[0];
            }
            catch (Exception) { return null; }
        }


        public DataTable GetAllUserData(string query) //polymorphism
        {
            try
            {
                //step1: connection string
                string myNwConnectionstring = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.NwConnString"].ConnectionString;


                myNwConnection = new SqlConnection(myNwConnectionstring);

                myNwConnection.Open();


                //step 5: Adapter
                SqlDataAdapter mynwDataAdapter = new SqlDataAdapter(query, myNwConnection);

                DataSet set = new DataSet();

                mynwDataAdapter.Fill(set);

                return set.Tables[0];
            }
            catch (Exception) { return null; }
        }
        public int DeleteUserData(string query)
        {
            try
            {
                //step1: connection string
                string myNwConnectionstring = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.NwConnString"].ConnectionString;


                myNwConnection = new System.Data.SqlClient.SqlConnection(myNwConnectionstring);

                myNwConnection.Open();


                SqlCommand cmd = new SqlCommand(query, myNwConnection);


                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }


        public void ConnectionClose()
        {
            myNwConnection.Close();
        }

    }
}

