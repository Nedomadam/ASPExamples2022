using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Third.Pages
{
    public class CalculateModel : PageModel
    {
        public int NumberA { get; set; }
        public int NumberB { get; set; }
        public int Result { get; set; }
        public string Operation { get; set; }
        public string ErrorMessage { get; set; }  = "";
        public IActionResult OnGet(int a, int b, string op)
        {
            NumberA = a;
            NumberB = b;
            Operation = op;
            switch (Operation) {
                case "plus": Result = NumberA + NumberB; break;
                case "minus": Result = NumberA - NumberB; break;
                case "times": Result = NumberA * NumberB; break;
                case "hell": return RedirectToPage("Panic");
                default: ErrorMessage = "I have no clue, what the bloody hell are you trying to do."; break;
            }
            return Page();
        }
    }
}
