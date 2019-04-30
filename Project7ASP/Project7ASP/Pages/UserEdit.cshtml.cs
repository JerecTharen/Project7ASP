using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project7ASP.DataModels;

namespace Project7ASP.Pages
{
    public class UserEditModel : PageModel
    {

        private readonly IUserData dbUserData;
        [BindProperty]
        public UserData EditUser{get; set;}

        public UserEditModel(IUserData dbUserData)
        {
            this.dbUserData = dbUserData;
        }

        public void OnGet(int uid)
        {
            EditUser = dbUserData.GetById(uid);
        }

        public void OnPost()
        {
            dbUserData.Update(EditUser);
            int commitInt = dbUserData.Commit();
            if (commitInt == 1)
            {
                Console.Beep();
            }
            else
            {
                Console.WriteLine(commitInt);
            }
        }
    }
}