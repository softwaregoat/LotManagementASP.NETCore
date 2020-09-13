using System;
using System.Collections.Generic;

namespace MVCCoreLoginRegister.Data
{
    public partial class TblMaterialLotControl
    {
        public int MaterialLotControlId { get; set; }
        public string LotName { get; set; }
        public string ProductName { get; set; }
        public string Des { get; set; }
        public DateTime? CurrentDate { get; set; }
        public bool? LogFile { get; set; }
        public DateTime? MlctimeStamp { get; set; }
        public int? CartonNo { get; set; }
        public string P1lot { get; set; }
        public string P2lot { get; set; }
        public string Mblot { get; set; }
        public string Salot { get; set; }
    }
}
