using CH.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CH.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
