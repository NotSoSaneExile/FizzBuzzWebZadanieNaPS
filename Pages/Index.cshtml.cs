using FizzBuzzWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FizzBuzzWeb.Pages.Data;

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly FizzBuzzContext _context;
        private readonly ILogger<IndexModel> _logger;
        [BindProperty(SupportsGet = true)]
        public FizzBuzz FizzBuzz { get; set; }
        public IndexModel(ILogger<IndexModel> logger, FizzBuzzContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IList<FizzBuzz> FizzBuzzDB { get; set; }
        public void OnGet()
        {
            FizzBuzzDB = _context.FizzBuzz.ToList();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                FizzBuzz.Out = FizzBuzz.Outcome();
                FizzBuzz.Data = System.DateTime.Now;
                HttpContext.Session.SetString("FizzBuzz", JsonConvert.SerializeObject(FizzBuzz));
                _context.FizzBuzz.Add(FizzBuzz);
                _context.SaveChangesAsync();
                return Page();
            }
            return Page();
        }

    }

}
