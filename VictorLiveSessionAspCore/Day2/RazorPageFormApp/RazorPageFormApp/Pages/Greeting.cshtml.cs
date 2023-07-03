using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageFormApp.Pages
{
    public class GreetingModel : PageModel
    {

        [BindProperty]
        public string UserName { get;set;}

        public string Message { get;set;}
        public void OnGet()
        {
        }

        public void OnPost() {
            //
            Message += $"Hello Mr {UserName},welcome to razor";
        }
    }
}
