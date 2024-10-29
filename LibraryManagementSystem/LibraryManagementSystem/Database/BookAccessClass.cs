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
    class BookAccessClass
    {
        SqlConnection myNwConnection;

        string myNwConnectionstring = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.NwConnString"].ConnectionString;

        public SqlConnection GetConnection()
        {
            if (myNwConnection == null)
            {
                myNwConnection = new SqlConnection(myNwConnectionstring);
            }

            return myNwConnection;
        }//end getConnection()

        public void OpenDbConnection()
        {
            //open connection
            if (myNwConnection.State == ConnectionState.Closed)
            {
                myNwConnection.Open();
            }//end if
        }//end openHWConnection();

        public void CloseDbConnection()
        {
            myNwConnection.Close();
        }

        public SqlDataReader GetReader(string query, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null)
        {
            SqlCommand cmd = new SqlCommand(query, this.GetConnection());
            cmd.CommandType = cmdType;

            if (param1 != null) cmd.Parameters.Add(param1);
            if (param2 != null) cmd.Parameters.Add(param2);
            if (param3 != null) cmd.Parameters.Add(param3);
            if (param4 != null) cmd.Parameters.Add(param4);
            if (param5 != null) cmd.Parameters.Add(param5);

            try
            {
                this.OpenDbConnection();
                return cmd.ExecuteReader();
            }
            finally
            {
                cmd.Dispose();
            }//end try finally
        }


        public DataTable GetAllBooks(string query, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null)
        {
            //load a data table from teh data base using wither a query or tect or a stored procedure name.
            DataTable table = new DataTable();
            SqlDataReader reader = null;
            try
            {
                reader = GetReader(query, cmdType, param1, param2, param3, param4, param5);
                table.Load(reader); //table load method fills a data table using the data reader
                reader.Close();
                return table;

            }
            finally
            {
                this.CloseDbConnection();
            }
        }


        //create an Execute Non query for insert book statement
        public int ExecNonQuery(string query, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6 = null)
        {
            SqlCommand cmd = new SqlCommand(query, this.GetConnection());
            cmd.CommandType = cmdType;
            //add the query parameters to the command
            if (param1 != null) cmd.Parameters.Add(param1);
            if (param2 != null) cmd.Parameters.Add(param2);
            if (param3 != null) cmd.Parameters.Add(param3);
            if (param4 != null) cmd.Parameters.Add(param4);
            if (param5 != null) cmd.Parameters.Add(param5);
            if (param6 != null) cmd.Parameters.Add(param6);

            try
            {
                this.OpenDbConnection();
                return cmd.ExecuteNonQuery();
            }
            finally
            {
                this.CloseDbConnection();
                cmd.Dispose();
            }//end try finally
        }

        public SqlDataReader CheckBookDataById(String query)
        {
            try
            {
                SqlConnection myNwConnection = new System.Data.SqlClient.SqlConnection(myNwConnectionstring);
                myNwConnection.Open();

                SqlCommand cmd = new SqlCommand(query, myNwConnection);
                SqlDataReader reader = cmd.ExecuteReader();

                return reader;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public SqlDataReader FillBookDataOnControls(string query, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null)
        {
            try
            {

                myNwConnection = new System.Data.SqlClient.SqlConnection(myNwConnectionstring);
                myNwConnection.Open();

                SqlCommand cmd = new SqlCommand(query, myNwConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                return reader;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable UpdateBook(string query, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null)
        {
            //load a data table from teh data base using wither a query or tect or a stored procedure name.
            DataTable table = new DataTable();
            SqlDataReader reader = null;
            try
            {
                reader = GetReader(query, cmdType, param1, param2, param3, param4, param5);
                table.Load(reader);
                reader.Close();
                return table;

            }
            finally
            {
                this.CloseDbConnection();
            }
        }

        public DataTable GetGenre(string query, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null)
        {
            //load a data table from teh data base using wither a query or tect or a stored procedure name.
            DataTable table = new DataTable();
            SqlDataReader reader = null;
            try
            {
                reader = GetReader(query, cmdType, param1, param2, param3, param4, param5);
                table.Load(reader); //table load method fills a data table using the data reader
                reader.Close();
                return table;

            }
            finally
            {
                this.CloseDbConnection();
            }

        }

        public DataSet GetNwData(string sqlQuery)
        {
            string ErrorReturned;
            //variable to store data 
            DataSet nwDataSet = new DataSet();
            try
            {
                //set up adapter with query and connection.
                SqlDataAdapter nwDataAdapter = new SqlDataAdapter(sqlQuery, GetConnection());
                this.OpenDbConnection();
                nwDataAdapter.Fill(nwDataSet);
                return nwDataSet;
            }
            catch (Exception ex)
            {
                //store the error data in the property
                ErrorReturned = ex.Message;
                return null;
            }
            finally
            {
                this.CloseDbConnection();
            }
        }
    }
}
