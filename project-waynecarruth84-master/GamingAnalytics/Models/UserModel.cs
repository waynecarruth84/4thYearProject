using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static GamingAnalytics.Models.Login;

namespace GamingAnalytics.Models
{
    public class UserModel
    {
        [Required, MaxLength(256)]
        public string FullName { get; set; }
        [Required, MaxLength(256)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

      
    }
}
