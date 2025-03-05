using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Entites
{
    public class PatientDiagnosis
    {
        public int PatientDiagnosisID { get; set; }
        public int PatientID { get; set; } // Foreign Key to Patient
        public int DiagnosisID { get; set; } // Foreign Key to Diagnosis
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Diagnosis { get; set; }
        public string Symptoms { get; set; }
        public string Medications { get; set; }
        public string SuggestedLifestyle { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
