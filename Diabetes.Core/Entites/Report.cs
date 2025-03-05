using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Entites
{
    public class Report
    {
        public int ReportID { get; set; }
        public int DoctorID { get; set; } // Foreign Key to Doctor
        public int CasualUserID { get; set; } // Foreign Key to CasualUser
        public int ManagerID { get; set; } // Foreign Key to Manager
        public string ReportType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Format { get; set; }
        public DateTime GeneratedAt { get; set; }
        public string FilePath { get; set; }

    }
}
