using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAttMgtSystem.Entities
{
    public class EmployeeView
    {
        public Guid IdentityId {  get; set; }   
        public string? FullName { get; set; }
        public string? Position { get; set; }
        public string? CardNo { get; set; }
    }
}
