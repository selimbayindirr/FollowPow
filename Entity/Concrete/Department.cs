using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmenName { get; set; }

        public ICollection<Person> Persons { get; set; }    
    }
}
