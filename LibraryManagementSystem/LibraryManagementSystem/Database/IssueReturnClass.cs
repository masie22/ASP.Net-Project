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
    class IssueReturnClass
    {
        //class level variables
        private SqlConnection lmsConnection;
        
        string lmsConnectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.NwConnString"].ConnectionString;

        public SqlConnection GetConnection()
        {
            if (lmsConnection == null)
            {
                lmsConnection = new SqlConnection(lmsConnectionString);
            }
            return lmsConnection;
        }
        public void OpenHwConnection()
        {
            if (lmsConnection.State == ConnectionState.Closed)
            {
                lmsConnection.Open();
            }//end if
        }

        public void CloseHWConnection()
        {
            lmsConnection.Close();
        }

        public DataSet GetData(string sqlQuery)
        {
            string ErrorReturned;
            //variable to store data 
            DataSet nwDataSet = new DataSet();
            try
            {
                //set up adapter with query and connection.
                SqlDataAdapter nwDataAdapter = new SqlDataAdapter(sqlQuery, GetConnection());
                this.OpenHwConnection();
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
                this.CloseHWConnection();
            }
        }

        public SqlDataReader CheckBookDataById(String query)
        {
            try
            {
                SqlConnection myNwConnection = new System.Data.SqlClient.SqlConnection(lmsConnectionString);
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
                this.OpenHwConnection();
                return cmd.ExecuteNonQuery();
            }
            finally
            {
                this.CloseHWConnection();
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
                this.CloseHWConnection();
            }
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
                this.OpenHwConnection();
                return cmd.ExecuteReader();
            }
            finally
            {
                cmd.Dispose();
            }//end try finally
        }

        public Object GetScalar(string procNameOrQuery, CommandType cmdType,
          SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null,
          SqlParameter param4 = null, SqlParameter param5 = null)
        {
            SqlCommand cmd = new SqlCommand(procNameOrQuery, this.GetConnection());
            cmd.CommandType = cmdType;
            //add query parameters to the command
            if (param1 != null) cmd.Parameters.Add(param1);
            if (param2 != null) cmd.Parameters.Add(param2);
            if (param3 != null) cmd.Parameters.Add(param3);
            if (param4 != null) cmd.Parameters.Add(param4);
            if (param5 != null) cmd.Parameters.Add(param5);

            try
            {
                this.OpenHwConnection();
                return cmd.ExecuteScalar();
            }
            finally
            {
                this.CloseHWConnection();
                cmd.Dispose();
            }
        }
    }
}
