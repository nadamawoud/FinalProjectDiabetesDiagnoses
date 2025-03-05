using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Entites
{
    public class SuspectDiabetesResult
    {
        public int SuspectResultID { get; set; }
        public string RiskLevel { get; set; }
        public DateTime AnalysisDate { get; set; }
        public string Recommendation { get; set; }

    }
}
