using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Entites
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ClerkID { get; set; } // Foreign Key to Clerk
        public int MedicalHistoryID { get; set; } // Foreign Key to MedicalHistory

    }
}
