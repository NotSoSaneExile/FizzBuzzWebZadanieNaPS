﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly FizzBuzzWeb.Pages.Data.FizzBuzzContext _context;

        public DetailsModel(FizzBuzzWeb.Pages.Data.FizzBuzzContext context)
        {
            _context = context;
        }

        public FizzBuzz FizzBuzz { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FizzBuzz = await _context.FizzBuzz.FirstOrDefaultAsync(m => m.Id == id);

            if (FizzBuzz == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}