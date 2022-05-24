using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamingAnalytics.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace GamingAnalytics.Pages
{
    public class LoginModel : PageModel
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public void OnGet()
        {
            //notready
        }
       
    }
}
