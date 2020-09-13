using System;
using System.Collections.Generic;

namespace MVCCoreLoginRegister.Data
{
    public partial class TblCavitationRecord
    {
        public int CavitationRecordId { get; set; }
        public string LotName { get; set; }
        public DateTime? PcptimeStamp { get; set; }
        public string Cav { get; set; }
        public DateTime? CurrentDate { get; set; }
        public bool? LogFile { get; set; }
        public int? CavityId { get; set; }
        public string Reason { get; set; }
        public string Action { get; set; }
    }
}
