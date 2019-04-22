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
        public void OnGet()
        {

        }

        public void OnPost(string userName, string firstName, string lastName, int age, string email)
        {
            //UserData NewUser = new UserData(userName, firstName, lastName, age, email);

        }
    }
}
