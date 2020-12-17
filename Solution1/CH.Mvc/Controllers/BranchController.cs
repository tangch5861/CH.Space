using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CH.Application.Interfaces;
using CH.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CH.Mvc.Controllers
{
    [Authorize]
    public class BranchController : Controller
    {
        private IBranchService _branchService;

        public BranchController(IBranchService branchService)
        {
            _branchService = branchService;
        }

        public IActionResult Index()
        {
            return View(_branchService.GetBranches());
        }
    }
}