using CH.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CH.Application.Interfaces
{
    public interface IBranchService
    {
        IEnumerable<BranchViewModel> GetBranches();
        void Create(BranchViewModel courseViewModel);
    }
}
