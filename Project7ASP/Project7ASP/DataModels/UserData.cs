using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project7ASP.DataModels
{
    public class UserData
    {
        public int Id { get; set; }
        public string user_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int age { get; set; }
        public string email { get; set; }

        //public UserData(string userName, string firstName, string lastName, int age, string email)
        //{
        //    UserName = userName;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Age = age;
        //    Email = email;
        //}
    }
}
