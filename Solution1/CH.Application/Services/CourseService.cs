using AutoMapper;
using AutoMapper.QueryableExtensions;
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
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper autoMapper)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateCourseCommand>(courseViewModel));
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return _courseRepository.GetCourses().ProjectTo<CourseViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
