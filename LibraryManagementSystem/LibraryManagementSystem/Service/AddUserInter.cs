using LibraryManagementSystem.Classes;
using LibraryManagementSystem.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Service
{
    class AddUserInter
    {

        public DataTable getAllUserData()
        {
            AddUserClass adduser = new AddUserClass();

            return adduser.GetAllUserData();
        }


        public DataTable getAllUserData(string usertype)
        {
            AddUserClass adduser = new AddUserClass();
            string nwSQLString = "Select * from UserTable where role ='" + usertype + "';";
            return adduser.GetAllUserData(nwSQLString);
        }


        public String registerUser(User user)
        {
            AddUserClass adduser = new AddUserClass();
            string nwSQLString = "Select * from UserTable where userid =" + user.UserId + ";";

            SqlDataReader reader = adduser.GetUserData(nwSQLString);

            if (reader.HasRows)
            {
                adduser.ConnectionClose();
                return "User already exists";
            }
            else
            {
                string nwString = "insert into UserTable (UserID,Name,Contact_No,Program,Level,Role,Username,Password) values (" + user.UserId + ", '" + user.Name + "', '" + user.Contact + "', '" + user.Program + "', '" + user.Level + "', '" + user.UserType + "', '" + user.Username + "', '" + user.Password + "');";
                AddUserClass addUser = new AddUserClass();

                addUser.ProcessUserData(nwString);

                //insert query
                //adduserclass insertUserData
                adduser.ConnectionClose();
                return "User added Successfully";

            }
        }
        public String insertUserDetail(User user)
        {
            AddUserClass adduser = new AddUserClass();

            string nwSQLString = "Select * from Login where userid =" + user.UserId + ";";

            SqlDataReader reader = adduser.GetUserData(nwSQLString);

            string nwSQLString2 = "Select * from UserTable where userid =" + user.UserId + ";";
            SqlDataReader reader2 = adduser.GetUserData(nwSQLString2);

            if (reader2.HasRows)
            {

                if (reader.HasRows)
                {
                    adduser.ConnectionClose();
                    return "User already exists";
                }
                else
                {
                    string nwString = "insert into Login (userid,usertype,username,password) values (" + user.UserId + ", '" + user.UserType + "', '" + user.Username + "', '" + user.Password + "');";
                    AddUserClass addUser = new AddUserClass();

                    addUser.ProcessUserData(nwString);

                    //insert query
                    //adduserclass insertUserData
                    adduser.ConnectionClose();
                    return "User added Successfully";

                }
            }
            else
            {
                adduser.ConnectionClose();
                return "User Doesn't exists";
            }
           

        }

        public User getUserDatafromID(string userid)
        {
            User user = new User();
            AddUserClass addUser = new AddUserClass();
            string nwSQLString = "Select * from UserTable where userid ='" +userid + "';";
            SqlDataReader reader = addUser.GetUserData(nwSQLString);

            if(reader.Read())
            {
                user.UserId = reader[0].ToString();
                user.Name = reader[1].ToString();
                user.Contact = reader[2].ToString();
                user.Program = reader[3].ToString();
                user.Level = reader[4].ToString();
                user.UserType = reader[5].ToString();
                user.Username = reader[6].ToString();
                user.Password = reader[7].ToString();
            }
            return user;
        }


        public string updateUser(User user)
        {
            AddUserClass addUser = new AddUserClass();
            string nwSQLString = "UPDATE UserTable SET Name = '"+user.Name+"'" +
                ", Contact_No = '"+user.Contact+"'" +
                ", Program = '"+user.Program+"'" +
                ", Level = '"+user.Level+"'" +
                ", Role = '"+user.UserType+"'" +
                " , Username = '"+user.Username+"'" +
                " , Password = '"+user.Password+"'" +
                " WHERE UserID = "+user.UserId+"; ";

            int rows = addUser.ProcessUserData(nwSQLString);

            return ((rows>0)?"User updated" : "Data not process");
            //TERNARY OPERATOR
            



            /////first delete statement
            ///call adduser
        }
        public string DeleteUser(User user)
        {
            AddUserClass addUser = new AddUserClass();

            string sqlString= "Delete UserTable where userid ='" + user.UserId + "';";

            int rows = addUser.DeleteUserData(sqlString);

            string sqlString1 = "Delete Login where userid ='" + user.UserId + "';";

            addUser.DeleteUserData(sqlString1);

            return ((rows > 0) ? "User Deleted" : "No User Data");

        }
    }
}
