using System;
using System.Collections.Generic;

namespace MVCCoreLoginRegister.Data
{
    public partial class QryLineClearanceRecords
    {
        public string LotName { get; set; }
        public DateTime? LctimeStamp { get; set; }
        public string TechUsername { get; set; }
        public string Qcusername { get; set; }
    }
}
