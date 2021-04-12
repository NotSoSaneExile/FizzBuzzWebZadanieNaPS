using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Models
{
    public class FizzBuzz
    {
        [Key]
        public int Id { get; set; }
        [Range(1, 1000, ErrorMessage = "Wymagany jest zakres od 1 do 1000"), Required]
        public int NumberInput { get; set; }
        [Required]
        public DateTime Data { get; set; }
        public string Out { get; set; }
        public string Outcome()
        {
            string Out = "";
            if(NumberInput % 3==0) { Out += "fizz";
            }
            if(NumberInput % 5==0) { Out += "buzz";
            }
            return Out;
        }
    }
}
