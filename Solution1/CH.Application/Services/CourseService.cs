using CH.Application.Interfaces;
using CH.Application.ViewModels;
using CH.Domain.Commands;
using CH.Domain.Core.Bus;
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
        private readonly IMediatorHandler _bus;
        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(
                    courseViewModel.Name,
                    courseViewModel.Description,
                    courseViewModel.ImageUrl
                );

            _bus.SendCommand(createCourseCommand);
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
