using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Project7ASP.DataModels
{
    public class UsersDB : IUserData
    {

        private readonly TestDB db;

        public UsersDB (TestDB db)
        {
            this.db = db;
        }

        public IEnumerable<UserData> GetAll()
        {
            return this.db.Users.ToList();
        }

        public UserData Add(UserData newUser)
        {
            db.Add(newUser);
            return newUser;
        }

        public int GetMax()
        {
            return db.Users.Max<UserData>(u => u.Id);
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public UserData Delete(int id)
        {
            var user = GetById(id);
            if(user != null)
            {
                db.Remove(user);
            }
            return user;
        }

        public UserData GetById(int id)
        {
            return db.Users.Find(id);
        }

        public IEnumerable<UserData> GetUserByUserName(string name)
        {
            var query = from u in db.Users
                        where u.user_name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby u.user_name
                        select u;
            return query;
        }

        public UserData Update(UserData updatedUser)
        {
            var entity = db.Users.Attach(updatedUser);
            entity.State = EntityState.Modified;
            return updatedUser;
        }
    }
}
