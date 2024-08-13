using Microsoft.AspNetCore.Mvc;

namespace HandsOnEdu.Controllers
{
    public class VolunteerController : Controller
    {
        [Route("Volunteer")]
        [HttpGet("Volunteer")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
