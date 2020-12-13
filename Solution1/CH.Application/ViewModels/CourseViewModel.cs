using CH.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CH.Application.ViewModels
{
    public class CourseViewModel
    {
        IEnumerable<Course> Courses { get; set; }
    }
}
