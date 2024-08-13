using Microsoft.AspNetCore.Mvc;

namespace HandsOnEdu.Controllers
{
    public class MST_VolunteerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
