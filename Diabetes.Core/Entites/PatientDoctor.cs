using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Entites
{
    public class PatientDoctor
    {
        public int PatientID { get; set; } // Foreign Key to Patient
        public int DoctorID { get; set; } // Foreign Key to Doctor

    }
}
