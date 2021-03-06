﻿using System;
using System.Collections.Generic;

namespace MVCCoreLoginRegister.Data
{
    public partial class TblQualityRecord
    {
        public int QualityRecordId { get; set; }
        public string LotName { get; set; }
        public DateTime? PcptimeStamp { get; set; }
        public string Cav { get; set; }
        public DateTime? CurrentDate { get; set; }
        public bool? LogFile { get; set; }
        public int? CavityId { get; set; }
        public string Observation { get; set; }
        public string Action { get; set; }
    }
}
