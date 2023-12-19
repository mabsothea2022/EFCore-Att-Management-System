using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAttMgtSystem.Entities
{
    public class Log
    {
        public Guid LogId { get; set; }
        public DateTime? TimeStamp { get; set; }
        public uint TimeShift { get; set; } //1,2,3,4
    }
}
