using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CH.Application.Interfaces;
using CH.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CH.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BranchController : ControllerBase
    {
        private readonly IBranchService _branchService;

        public BranchController(IBranchService branchService)
        {
            _branchService = branchService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] BranchViewModel branchViewModel)
        {
            _branchService.Create(branchViewModel);

            return Ok(branchViewModel);
        }
    }
}
