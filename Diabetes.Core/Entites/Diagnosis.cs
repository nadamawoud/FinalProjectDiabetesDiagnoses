using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Entites
{
    public class Diagnosis
    {
        public int DiagnosisID { get; set; }
        public string Symptoms { get; set; }
        public string LabResults { get; set; }
        public string DiagnosisResult { get; set; }
        public string SuggestedLifestyle { get; set; }
        public DateTime DiagnosisDate { get; set; }

    }
}
