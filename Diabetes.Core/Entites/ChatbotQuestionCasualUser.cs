using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Entites
{
    public class ChatbotQuestionCasualUser
    {
        public int ChatbotQuestionCasualUserID { get; set; }
        public string ChatbotQuestionCasualUserText { get; set; }
        public int AdminID { get; set; } // Foreign Key to Admin

    }
}
