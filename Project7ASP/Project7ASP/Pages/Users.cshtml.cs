using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project7ASP.DataModels;

namespace Project7ASP.Pages
{
    public class UsersModel : PageModel
    {
        public List<UserData> AllUsers;
        public IEnumerable<UserData> Users { get; set; }
        private readonly IUserData dbUsers;


        public UsersModel(IUserData dbUsers)
        {
            this.dbUsers = dbUsers;
        }

        public void OnGet()
        {
            //AllUsers = new List<UserData>();
            //AllUsers.Add(new UserData() { Id = 1, age = 1, email = "testing@test.com", user_name = "test123", first_name = "tester", last_name = "testing" });
            //AllUsers.Add(new UserData() { Id = 2, age = 2, email = "test123@test.com", user_name = "test456", first_name = "testme", last_name = "person" });
            //AllUsers.Add(new UserData() { Id = 3, age = 10, email = "tester@test.com", user_name = "test789", first_name = "human", last_name = "testing" });
            Users = dbUsers.GetAll();
            //var DBUsers = this.db.GetUserByUserName("");
        }
        public void OnPost(string searchTerm)
        {
            Users = dbUsers.GetUserByUserName(searchTerm);
        }
    }
}