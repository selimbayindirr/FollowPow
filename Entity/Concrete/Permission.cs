using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public string Name { get; }
        public bool IsAllowed { get; set; }
        public string Description { get; set; }
        public string LeaveStart { get; set; }
        public string LeaveEnd { get; set; }
        public int PermissionTypeId { get; set; }
        public PermissionType PermissionType { get; set; }


    }
}
