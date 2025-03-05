using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diabetes.Core.Entites
{
    public class Clerk
    {
        public int ClerkID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string LicenseCode { get; set; }
        public string Phone { get; set; }
        public string PasswordHash { get; set; }

    }
}
