using Microsoft.AspNetCore.Mvc;

namespace Manager_SIMS.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
