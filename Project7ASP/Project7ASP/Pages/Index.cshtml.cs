using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project7ASP.DataModels;

namespace Project7ASP.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IUserData dbUserData;

        public bool ShowSuccess { get; set; }
        public bool ShowFail { get; set; }

        public IndexModel(IUserData dbUserData)
        {
            this.dbUserData = dbUserData;
        }

        public void OnGet()
        {

        }

        public void OnPost(string userName, string firstName, string lastName, int age, string email)
        {
            Int64 Id = this.dbUserData.GetMax() + 1;
            UserData NewUser = new UserData() { Id = Id, user_name = userName, first_name = firstName, last_name = lastName, age=age, email=email};
            this.dbUserData.Add(NewUser);
            switch(this.dbUserData.Commit())
            {
                case 1:
                    this.ShowSuccess = true;
                    break;
                default:
                    this.ShowFail = true;
                    break;
            }

        }
    }
}
