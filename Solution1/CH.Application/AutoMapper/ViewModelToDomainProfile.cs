using AutoMapper;
using CH.Application.ViewModels;
using CH.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CH.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<BranchViewModel, CreateBranchCommand>();
        }
    }
}
