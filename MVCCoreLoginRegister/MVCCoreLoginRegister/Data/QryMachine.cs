using System;
using System.Collections.Generic;

namespace MVCCoreLoginRegister.Data
{
    public partial class QryMachine
    {
        public int MachineId { get; set; }
        public int? TechnologyId { get; set; }
        public string MachineName { get; set; }
    }
}
