using ASP.NETCore_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NETCore_RazorPages.Pages
{
    public class SignInModel : PageModel
    {
        public string PageTitle { get; set; } = "Sign in";

        [BindProperty]
        public SignInFormViewModel Form { get; set; } = new SignInFormViewModel();

        private string title;

        public string Title { get { return title; } set { title = value; } }

        public void OnGet()
        {
            Form = new SignInFormViewModel();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/index");
        }
    }
}
