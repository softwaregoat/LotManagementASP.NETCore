using System;
using System.Collections.Generic;

namespace MVCCoreLoginRegister.Data
{
    public partial class TblLot
    {
        public int LotId { get; set; }
        public string LotName { get; set; }
        public decimal? Loq { get; set; }
        public string MachineName { get; set; }
        public string ProductName { get; set; }
    }
}
