using FizzBuzzWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace FizzBuzzWeb.Pages.Data
{
    public class FizzBuzzContext: DbContext {
        public DbSet<FizzBuzz> FizzBuzz { get; set; }

    }
}
