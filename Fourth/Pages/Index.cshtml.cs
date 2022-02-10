using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fourth.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public double Value { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(double value)
        {
            Value = value;
        }

        /*
         * Nebude fungovat oba se cpou na stejný místo
        public async Task OnGetAsync()
        {
            Value = value;
            return;
        }
        */

        public void OnGetInc(double value)
        {
            Value = value + 1;
        }

        public void OnGetDec(double value)
        {
            Value = value - 1;
        }

        public void OnPost(double value)
        {
            Value = value;
        }
    }
}
