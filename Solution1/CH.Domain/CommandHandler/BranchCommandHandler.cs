using CH.Domain.Commands;
using CH.Domain.Interfaces;
using CH.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CH.Domain.CommandHandler
{
    public class BranchCommandHandler : IRequestHandler<CreateBranchCommand, bool>
    {
        private readonly IBranchRepository _branchRepository;

        public BranchCommandHandler(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        public Task<bool> Handle(CreateBranchCommand request, CancellationToken cancellationToken)
        {
            var branch = new Branch()
            {
                CompanyName = request.CompanyName,
                RegistrationNo = request.RegistrationNo,
                Mobile = request.Mobile,
                Address = request.Address,
                Address2 = request.Address2,
                State = request.State,
                PostalCode = request.PostalCode
            };

            _branchRepository.Add(branch);

            return Task.FromResult(true);
        }
    }
}
