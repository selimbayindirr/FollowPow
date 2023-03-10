using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Person
    {
        public int PersonId { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int PositionId { get; set; }
        public int DepartmentId { get; set; }
        public double Salary { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string StartingDate { get; set; }

       public Department Department { get; set; }
        public Position Position { get; set; }


    }
}
