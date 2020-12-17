﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CH.Domain.Models
{
    public class Branch
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string RegistrationNo { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
    }
}
