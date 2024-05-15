using ASP.NETCore_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NETCore_RazorPages.Pages
{
    public class SignUpModel : PageModel
    {
        public string PageTitle { get; set; } = "Sign upp";

        public bool IsChecked { get; set; }

        [BindProperty]
        public SignUpFormViewModel Form { get; set; } = new SignUpFormViewModel();

        private string title;

        public string Title { get { return title; } set {  title = value; } }

        public void OnGet()
        {
            Form = new SignUpFormViewModel();
        }

        public IActionResult OnPost()
        {
           if(!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/index");
        }
    }
}
