using Microsoft.AspNetCore.Mvc;

namespace HandsOnEdu.Controllers
{
	public class EventController : Controller
	{
		[Route("Event")]
		[HttpGet("Event")]
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet("Show")]
		public IActionResult Show()
		{
			return View();
		}
	}
}
