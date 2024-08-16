using Microsoft.AspNetCore.Mvc;

namespace HandsOnEdu.Controllers
{
    public class MST_Blog : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
