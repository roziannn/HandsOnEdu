using Microsoft.AspNetCore.Mvc;

namespace HandsOnEdu.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
