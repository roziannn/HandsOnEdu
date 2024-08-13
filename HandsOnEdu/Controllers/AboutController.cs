using Microsoft.AspNetCore.Mvc;

namespace HandsOnEdu.Controllers
{
	public class AboutController : Controller
	{
		[Route("About")]
		[HttpGet("About")]
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet("Contact")]
		public IActionResult Contact()
		{
			return View();
		}
	}
}
