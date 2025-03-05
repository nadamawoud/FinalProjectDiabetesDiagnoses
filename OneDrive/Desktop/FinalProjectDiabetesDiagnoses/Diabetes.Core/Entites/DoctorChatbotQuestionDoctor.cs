using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Entites
{
    public class DoctorChatbotQuestionDoctor
    {
        public int DoctorID { get; set; } // Foreign Key to Doctor
        public int ChatbotQuestionDoctorID { get; set; } // Foreign Key to ChatbotQuestionDoctor

    }
}
