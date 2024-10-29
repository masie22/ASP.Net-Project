using LibraryManagementSystem.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Service
{
    public class ForgotLoginInter
    {
        public Boolean getForgotPassword(String username, String password, String confirmpassword)
        {
            ForgotLogin database = new ForgotLogin();
            string nwSQLString = "Update [Login] set [password]='" + password + "'where username='" + username + "'";

            SqlDataReader reader = database.getForgotPassword(nwSQLString);


            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
