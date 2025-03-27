using Microsoft.AspNetCore.Mvc;

namespace Manager_SIMS.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
