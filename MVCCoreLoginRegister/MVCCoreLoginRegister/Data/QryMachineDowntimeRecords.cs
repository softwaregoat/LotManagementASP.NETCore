using System;
using System.Collections.Generic;

namespace MVCCoreLoginRegister.Data
{
    public partial class QryMachineDowntimeRecords
    {
        public string LotName { get; set; }
        public DateTime? PcptimeStamp { get; set; }
        public string Comment { get; set; }
    }
}
