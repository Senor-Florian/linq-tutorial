using LINQ_Tutorial.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial.DataAccess
{
    public class UserPoco
    {
        public Guid ID { get; set; }
        public string LOGINNAME { get; set; }
        public string FULLNAME { get; set; }
        public int USERROLE { get; set; }
        public int? COUNTRYCODE { get; set; }

        public override string ToString()
        {
            return "Login name: " + LOGINNAME + ", FullName: " + FULLNAME + ", User role: " + ((UserRole)USERROLE).ToString();
        }
    }
}
