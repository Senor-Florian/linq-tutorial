using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial
{
    public class User
    {
        public Guid ID { get; set; }
        public Guid InstitutionID { get; set; }
        public string LoginName { get; set; }
        public string FullName { get; set; }
        public UserRole UserRole { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<string> Hobbies { get; set; } = new List<string>();

        public override string ToString()
        {
            return "Login name: " + LoginName + ", FullName: " + FullName + ", User role: " + UserRole.ToString() + ", Date of birth: " + DateOfBirth;
        }
    }
}
