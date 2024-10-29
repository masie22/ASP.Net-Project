using LibraryManagementSystem.Classes;
using LibraryManagementSystem.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Service
{
    class Login_inter
    {
        public Boolean Getdata(User user)
        {
            LoginDatabase database = new LoginDatabase();   //instantiating the Logindatabase Class

            string nwSQLString = "Select * from Login where usertype='" + user.UserType + "' and username ='" + user.Username + "' and password ='" + user.Password + "';";


            SqlDataReader reader = database.Getdata(nwSQLString);


            if (reader.HasRows)
            {
                //database.ConnectionClose();
                
                return true;//correct combination
            }
            else
            {
                //database.ConnectionClose();
                return false;
            }


        }


    public string ForgotPassword(User user)
        {
            LoginDatabase loginDatabase = new LoginDatabase();

            string query = "Select * from Login where userid =" +user.UserId+ " and username ='"+user.Username+ "';";
            SqlDataReader reader = loginDatabase.Getdata(query);

            if(reader.HasRows)
            {
                string updatequery= "Update Login set password ='"+user.Password+"' where userid =" + user.UserId + " and username ='" + user.Username + "';";

                loginDatabase.ProcessData(updatequery);

                string updatequery1 = "Update UserTable set Password ='" + user.Password + "' where UserID =" + user.UserId + " and Username ='" + user.Username + "';";

                loginDatabase.ProcessData(updatequery1);

                loginDatabase.ConnectionClose();

                return "Password Updated Successfully";
            }
            else
            {
                loginDatabase.ConnectionClose();

                return "Invalid UserId and Username";
            }

        }
    }
}
