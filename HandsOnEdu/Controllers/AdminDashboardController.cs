using Microsoft.AspNetCore.Mvc;

namespace HandsOnEdu.Controllers
{
    public class AdminDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
