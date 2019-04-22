using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project7ASP.DataModels;

namespace Project7ASP.DataModels
{
    public class TestDB: DbContext
    {
        public TestDB(DbContextOptions<TestDB> options): base(options)
        {

        }

        public DbSet<UserData> Users { get; set; }
    }
}
