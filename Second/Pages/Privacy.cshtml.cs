using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Second.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Second.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public int Number { get; set; } = 7;

        public string Text { get; set; } = "Ahoj";
        public bool Fake { get; set; } = true;

        public UserData FavoriteUser{ get; set; } = new UserData { Firstname = "Květoslav"};
        public List<UserData> List { get; set; } = new List<UserData> {
            new UserData { Firstname = "Antonín"},
            new UserData { Firstname = "Bořivoj"},
            new UserData { Firstname = "Ctibor"},
            new UserData { Firstname = "Dalimil"},
            new UserData { Firstname = "Evžen"},
            new UserData { Firstname = "Flora"},
            new UserData { Firstname = "Gretchen"}
        };
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
