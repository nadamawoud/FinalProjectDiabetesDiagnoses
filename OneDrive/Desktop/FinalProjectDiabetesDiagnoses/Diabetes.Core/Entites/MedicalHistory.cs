using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Entites
{
    public class MedicalHistory
    {
        public int MedicalHistoryID { get; set; }
        public int DoctorID { get; set; } // Foreign Key to Doctor
        public string Diagnosis { get; set; }
        public string ChatbotData { get; set; }
        public DateTime DiagnosisDate { get; set; }
        public int AdminID { get; set; } // Foreign Key to Admin

    }
}
