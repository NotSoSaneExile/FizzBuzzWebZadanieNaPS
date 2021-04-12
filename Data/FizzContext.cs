using FizzBuzzWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace FizzBuzzWeb.Pages.Data
{
    public class FizzBuzzContext : DbContext
    {
        public FizzBuzzContext() { }
        public FizzBuzzContext(DbContextOptions options) : base(options) { }
        public DbSet<FizzBuzz> FizzBuzz { get; set; }

    }
}
