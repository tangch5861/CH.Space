using CH.Domain.Interfaces;
using CH.Domain.Models;
using CH.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH.Infra.Data.Repository
{
    public class BranchRepository : IBranchRepository
    {
        private UniversityDBContext _ctx;

        public BranchRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(Branch course)
        {
            _ctx.Branches.Add(course);
            _ctx.SaveChanges();
        }

        public IQueryable<Branch> GetBranches()
        {
            return _ctx.Branches;
        }
    }
}
