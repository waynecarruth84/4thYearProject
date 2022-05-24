using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GamingAnalytics.Models
{


        public class RiotApiContext : DbContext
        {
            public RiotApiContext(DbContextOptions<RiotApiContext> options)
                : base(options)
            {
            }

            public DbSet<RiotItem> TodoItems { get; set; }
        }
}
