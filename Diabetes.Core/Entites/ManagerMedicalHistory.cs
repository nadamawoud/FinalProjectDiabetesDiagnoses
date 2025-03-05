using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Entites
{
    public class ManagerMedicalHistory
    {
        public int ManagerID { get; set; } // Foreign Key to Manager
        public int MedicalHistoryID { get; set; } // Foreign Key to MedicalHistory

    }
}
