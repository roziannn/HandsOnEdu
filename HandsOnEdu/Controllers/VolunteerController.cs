﻿using Microsoft.AspNetCore.Mvc;

namespace HandsOnEdu.Controllers
{
    [Route("Volunteer")]
    public class VolunteerController : Controller
    {
        [HttpGet]
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
