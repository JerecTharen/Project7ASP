using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project7ASP.DataModels;

namespace Project7ASP.Pages
{
    public class DeleteUserModel : PageModel
    {

        private readonly IUserData dbUserData;
        public int UserId {get; set;}
        public UserData deleteUser;

        public DeleteUserModel(IUserData dbUserData)
        {
            this.dbUserData = dbUserData;
        }

        public void OnGet(int id)
        {
            UserId = id;
            deleteUser = dbUserData.GetById(id);
        }

        public void OnPost()
        {
            dbUserData.Delete(UserId);
            dbUserData.Commit();
        }
    }
}