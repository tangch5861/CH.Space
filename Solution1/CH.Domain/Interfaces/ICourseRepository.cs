using CH.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IQueryable<Course> GetCourses();
        void Add(Course course);
    }
}
