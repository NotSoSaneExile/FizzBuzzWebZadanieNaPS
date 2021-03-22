using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


namespace FizzBuzzWeb.Pages
{
    public class Index1Model : PageModel
    {
        public FizzBuzz FizzBuzz;
        public void OnGet()
        {
                var sessionAddress = HttpContext.Session.GetString("FizzBuzz");
            if (sessionAddress != null)
                FizzBuzz = JsonConvert.DeserializeObject<FizzBuzz>(sessionAddress);
        }
    }
}


