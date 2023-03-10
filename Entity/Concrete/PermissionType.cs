using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class PermissionType
    {
        public int PermissionTypeId { get; set; }
        public string ExcuseBrand { get; set; }

        public ICollection<Permission> Permissions { get; set; }
    }
}
