using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartment.Models
{
    public class Group
    {
        public string Name { get; set; }
        public Student GroupLeader { get; set; }
        public Department ProfileDepartment { get; set; }
    }
}
