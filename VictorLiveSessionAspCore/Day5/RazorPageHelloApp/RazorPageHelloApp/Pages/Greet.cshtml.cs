using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageHelloApp.Pages
{
   [IgnoreAntiforgeryToken]
    public class GreetModel : PageModel
    {

        public string Message { get; set; } = "Welcome,";
       
        [BindProperty]
        public string UserName { get; set; } = "Anonymous";
        public void OnGet()
        {
        }

        public void OnPost() { 
          Message += UserName;
        }
    }
}
