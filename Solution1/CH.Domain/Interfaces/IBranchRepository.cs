using CH.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH.Domain.Interfaces
{
    public interface IBranchRepository
    {
        IQueryable<Branch> GetBranches();
        void Add(Branch branch);
    }
}
