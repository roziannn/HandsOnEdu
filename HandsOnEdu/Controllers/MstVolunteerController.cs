using HandsOnEdu.Data;
using HandsOnEdu.Models.Entities;
using HandsOnEdu.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HandsOnEdu.Controllers
{
    [Route("MstVolunteer")]

    public class MstVolunteerController(ApplicationDbContext context, IMstVolunteerPostServices volunteerPostServices) : Controller
    {
        private readonly ApplicationDbContext _context = context;
        private readonly IMstVolunteerPostServices _mstVolunteerPostService = volunteerPostServices;

        [HttpGet("Index")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("SubmitPost")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MstVolunteeringPost model)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();

            if (ModelState.IsValid)
            {
                await _mstVolunteerPostService.Create(model);

                return Json(new { success = true, message = "Successfully created" });
            }
            else
            {
                var error = string.Join("; ", errors);
                return Json(new { success = false, message = error });
            }
        }

        [HttpGet("Show")]
        public IActionResult Show()
        {
            return View();
        }
    }
}
