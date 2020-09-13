﻿using System;
using System.Collections.Generic;

namespace MVCCoreLoginRegister.Data
{
    public partial class TblLineClearance
    {
        public int LineClearanceId { get; set; }
        public string LotName { get; set; }
        public DateTime? CurrentDate { get; set; }
        public bool? LogFile { get; set; }
        public DateTime? LctimeStamp { get; set; }
        public string TechRfid { get; set; }
        public string TechUsername { get; set; }
        public string Qcrfid { get; set; }
        public string Qcusername { get; set; }
    }
}
