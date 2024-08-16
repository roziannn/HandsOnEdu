using Microsoft.AspNetCore.Mvc;

namespace HandsOnEdu.Controllers
{
	[Route("Blog")]

	public class BlogController : Controller
	{
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
