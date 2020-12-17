using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CH.Application.Interfaces;
using CH.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CH.Mvc.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            return View(_courseService.GetCourses());
        }
    }
}