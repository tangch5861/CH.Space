﻿using CH.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CH.Application.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
        void Create(CourseViewModel courseViewModel);
    }
}
