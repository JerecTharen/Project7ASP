﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project7ASP.DataModels
{
    public interface IUserData
    {
        IEnumerable<UserData> GetUserByUserName(string name);
        UserData GetById(int id);
        UserData Update(UserData updatedUser);
        UserData Add(UserData newUser);
        UserData Delete(int id);
        int Commit();
    }
}