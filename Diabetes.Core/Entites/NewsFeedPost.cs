using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Entites
{
    public class NewsFeedPost
    {
        public int PostID { get; set; }
        public int OrganizationID { get; set; } // Foreign Key to Organization
        public int MedicalSyndicateID { get; set; } // Foreign Key to MedicalSyndicate
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageURL { get; set; }
        public string VideoURL { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
