using System;
using System.Collections.Generic;

namespace MVCCoreLoginRegister.Data
{
    public partial class TblMachine
    {
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public int? TechnologyId { get; set; }
    }
}
