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
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository _branchRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public BranchService(IBranchRepository branchRepository, IMediatorHandler bus, IMapper autoMapper)
        {
            _branchRepository = branchRepository;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        public void Create(BranchViewModel branchViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateBranchCommand>(branchViewModel));
        }

        public IEnumerable<BranchViewModel> GetBranches()
        {
            return _branchRepository.GetBranches().ProjectTo<BranchViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
