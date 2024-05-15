using ASP.NETCore_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCore_RazorPages.Controllers
{
    public class AuthController : Controller
    {

        [HttpGet]
        [Route("/signup")]
        public IActionResult SignUp() { return View(new SignUpFormViewModel()); }

        [HttpPost]
        [Route("/signup")]
        public IActionResult SignUp(SignUpFormViewModel viewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(viewModel);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
