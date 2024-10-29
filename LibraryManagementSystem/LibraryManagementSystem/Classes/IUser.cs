using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Classes
{
    interface IUser
    {
         string Username { get; set; }
         string Password { get; set; }
         string UserType { get; set; }
         string Name { get; set; }
        string Program { get; set; }
        string Level { get; set; }
        string Contact { get; set; }
        string UserId { get; set; }
       


    }
}
