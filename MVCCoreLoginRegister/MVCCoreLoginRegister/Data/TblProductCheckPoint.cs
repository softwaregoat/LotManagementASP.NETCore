using System;
using System.Collections.Generic;

namespace MVCCoreLoginRegister.Data
{
    public partial class TblProductCheckPoint
    {
        public int ProductCheckpointId { get; set; }
        public string LotName { get; set; }
        public string ProductName { get; set; }
        public string Des { get; set; }
        public DateTime? CurrentDate { get; set; }
        public bool? LogFile { get; set; }
        public TimeSpan? CheckPoint { get; set; }
        public DateTime? PcptimeStamp { get; set; }
        public bool? McRunning { get; set; }
        public int? CartonNo { get; set; }
        public int? ActiveCavities { get; set; }
        public decimal? ShotWeight { get; set; }
        public int? CycleCount { get; set; }
        public bool? Rejects { get; set; }
    }
}
