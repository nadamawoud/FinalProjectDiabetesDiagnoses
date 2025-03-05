using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Entites
{
    public class Symptoms
    {
        public int SymptomID { get; set; }
        public int CasualUserID { get; set; } // Foreign Key to CasualUser
        public int SuspectResultID { get; set; } // Foreign Key to SuspectDiabetesResult
        public string Name { get; set; }
        public int SeverityLevel { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
