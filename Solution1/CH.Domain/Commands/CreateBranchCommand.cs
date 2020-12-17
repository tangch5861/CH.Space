using System;
using System.Collections.Generic;
using System.Text;

namespace CH.Domain.Commands
{
    public class CreateBranchCommand : BranchCommand
    {
        public CreateBranchCommand(
            string companyName, 
            string registrationNo,
            string mobile,
            string address,
            string address2,
            string state,
            int postalCode
        )
        {
            CompanyName = companyName;
            RegistrationNo = registrationNo;
            Mobile = mobile;
            Address = address;
            Address2 = address2;
            State = state;
            PostalCode = postalCode;
        }
    }
}
