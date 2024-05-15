using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCore_RazorPages.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
