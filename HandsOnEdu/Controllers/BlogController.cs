using Microsoft.AspNetCore.Mvc;

namespace HandsOnEdu.Controllers
{
	public class BlogController : Controller
	{
		[HttpGet("Blog")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
