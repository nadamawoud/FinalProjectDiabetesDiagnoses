using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Entites
{
    public class SuggestionFood
    {
        public int FoodID { get; set; }
        public int PatientID { get; set; } // Foreign Key to Patient
        public string FoodName { get; set; }
        public string Description { get; set; }
        public string SuggestedBy { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
