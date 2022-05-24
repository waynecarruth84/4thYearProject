using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GamingAnalytics.Data
{
    public class GamingAnalyticsContext : IdentityDbContext<IdentityUser>
    {
        public GamingAnalyticsContext(DbContextOptions<GamingAnalyticsContext> options)
            : base(options)
        {
        }

    }
}
