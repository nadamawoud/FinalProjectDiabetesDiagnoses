using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Entites
{
    public class PatientMedicalHistory
    {
        public int PatientID { get; set; } // Foreign Key to Patient
        public int MedicalHistoryID { get; set; } // Foreign Key to MedicalHistory

    }
}
