﻿using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            this._courseService = courseService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CourseViewModel courseViewModel)
        {
            this._courseService.Create(courseViewModel);

            return Ok(courseViewModel);
        }

    }
}
