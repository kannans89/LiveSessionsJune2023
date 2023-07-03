using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageFormApp.Pages
{
    public class IndexModel : PageModel
    {

        public string Message { get; set; } = "Hello from Index";

        public void OnGet()
        {
        }
    }
}
