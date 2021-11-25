using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Mvc.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private ICourseService _courserService;

        public CourseController(ICourseService courserService)
        {
            this._courserService = courserService;
        }

        public IActionResult Index()
        {
            CourseViewModel model = this._courserService.GetCourses();


            return View(model);
        }
    }
}
