﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Project7ASP.DataModels
{
    public class UserData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }
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
