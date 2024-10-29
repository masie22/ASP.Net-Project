using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Classes
{
   public class User : IUser
    {
        private string userName;

        public string Username
        {
            get { return userName; }
            set { userName = value; }
        }

        private string passWord;

        public string Password
        {
            get { return passWord; }
            set { passWord = value; }
        }
       
        private string userType;   // fields are always private 

        public string UserType      // properties to access the fields outside the class
        {
            get { return userType; }
            set { userType = value; }
        }
        private string userId;
        public string UserId 
        { 
            get { return userId; }
            set { userId = value; }
             }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string contact;
        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        private string program;
        public string Program
        {
            get { return program; }
            set { program = value; }
        }
        private string level;
        public string Level
        {
            get { return level; }
            set { level = value; }
        }

        public User() { }       // default constructor 

        public User(string uName, string uPass, string uType)  //parameterized constructor
        {
            userName = uName;
            passWord = uPass;
            userType = uType;

        }

       
    }
}
