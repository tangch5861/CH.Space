using CH.Application.Interfaces;
using CH.Application.ViewModels;
using CH.Domain.Interfaces;
using CH.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CH.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
