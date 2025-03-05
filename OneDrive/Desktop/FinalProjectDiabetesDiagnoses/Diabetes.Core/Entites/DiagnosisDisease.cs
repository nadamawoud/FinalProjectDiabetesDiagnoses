using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Entites
{
    public class DiagnosisDisease
    {
        public int DiagnosisID { get; set; } // Foreign Key to Diagnosis
        public int DiseaseID { get; set; } // Foreign Key to Disease

    }
}
