using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project7ASP.DataModels
{
    public interface IUserData
    {
        IEnumerable<UserData> GetUserByUserName(string name);
        IEnumerable<UserData> GetAll();
        UserData GetById(Int64 id);
        UserData Update(UserData updatedUser);
        UserData Add(UserData newUser);
        UserData Delete(Int64 id);
        Int64 GetMax();
        int Commit();
    }
}
