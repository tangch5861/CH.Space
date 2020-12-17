using AutoMapper;
using CH.Application.ViewModels;
using CH.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CH.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Course, CourseViewModel>();
            CreateMap<Branch, BranchViewModel>();
        }
    }
}
