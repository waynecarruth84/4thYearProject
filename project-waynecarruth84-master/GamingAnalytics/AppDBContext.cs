using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamingAnalytics.Models;

namespace GamingAnalytics
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {

        }
        public DbSet<UserModel> User { get; set; }
    }
}
