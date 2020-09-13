using System;
using System.Collections.Generic;

namespace MVCCoreLoginRegister.Data
{
    public partial class TblMachineDowntimeRecord
    {
        public int MachineDowntimeId { get; set; }
        public string LotName { get; set; }
        public DateTime? PcptimeStamp { get; set; }
        public string Cav { get; set; }
        public string Comment { get; set; }
    }
}
