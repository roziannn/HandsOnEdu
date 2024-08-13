using Microsoft.AspNetCore.Mvc;

namespace HandsOnEdu.Controllers
{
	public class DonateController : Controller
	{
		[HttpGet("Donate")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
