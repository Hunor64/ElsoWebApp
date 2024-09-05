using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ElsoWebApp.Pages
{
    public class SzorzotablaModel : PageModel
    {
        [BindProperty]

        public int Szam { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            return Page();
        }
    }
}
