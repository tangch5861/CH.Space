using CH.Domain.Interfaces;
using CH.Domain.Models;
using CH.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CH.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctx;

        public CourseRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
