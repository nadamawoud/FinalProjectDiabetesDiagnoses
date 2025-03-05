using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Entites
{
    public class CasualUserChatbotQuestionCasualUser
    {
        public int CasualUserID { get; set; } // Foreign Key to CasualUser
        public int ChatbotQuestionCasualUserID { get; set; } // Foreign Key to ChatbotQuestionCasualUser

    }
}
