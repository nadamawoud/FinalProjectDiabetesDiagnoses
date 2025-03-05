﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Entites
{
    public class MedicalSyndicate
    {
        public int MedicalSyndicateID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ProfileDescription { get; set; }
        public string Logo { get; set; }
        public bool VerificationStatus { get; set; }
        public string PasswordHash { get; set; }

    }
}
