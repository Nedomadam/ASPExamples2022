using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace First.Pages
{
    public class FirstModel : PageModel
    {
        public int A { get; set; } = 100;
        public void OnGet()
        {
        }
    }
}
