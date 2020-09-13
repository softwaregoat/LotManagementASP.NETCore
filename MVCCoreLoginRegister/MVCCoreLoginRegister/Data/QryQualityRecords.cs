using System;
using System.Collections.Generic;

namespace MVCCoreLoginRegister.Data
{
    public partial class QryQualityRecords
    {
        public string LotName { get; set; }
        public DateTime? PcptimeStamp { get; set; }
        public string Observation { get; set; }
        public int? CavityId { get; set; }
        public string Action { get; set; }
    }
}
