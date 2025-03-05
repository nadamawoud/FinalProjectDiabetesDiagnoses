using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Entites
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public int MedicalSyndicateID { get; set; } // Foreign Key to MedicalSyndicate
        public string DoctorTitle { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string MedicalSyndicateCardNumber { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string VerificationStatus { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
