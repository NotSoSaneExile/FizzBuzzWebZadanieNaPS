using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FizzBuzzWeb.Models;
using FizzBuzzWeb.Pages.Data;

namespace FizzBuzzWeb.Pages.FizzBaza
{
    public class IndexModel : PageModel
    {
        private readonly FizzBuzzWeb.Pages.Data.FizzBuzzContext _context;

        public IndexModel(FizzBuzzWeb.Pages.Data.FizzBuzzContext context)
        {
            _context = context;
        }

        public IList<FizzBuzz> FizzBuzz { get;set; }

        public void OnGet()
        {
            var FizzBuzzQuery = from FizzBuzz in _context.FizzBuzz
                                orderby FizzBuzz.Data descending
                                select FizzBuzz;
            FizzBuzz = FizzBuzzQuery.Take(10).ToList();
        }
    }
}
