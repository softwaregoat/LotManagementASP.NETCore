using System;
using System.Collections.Generic;

namespace MVCCoreLoginRegister.Data
{
    public partial class QryFunctionalTestRecords
    {
        public string LotName { get; set; }
        public string ProductName { get; set; }
        public string Des { get; set; }
        public DateTime? FttimeStamp { get; set; }
        public int? CartonNo { get; set; }
        public int? SampleSize { get; set; }
        public string TestType { get; set; }
        public string Result { get; set; }
        public string Comment { get; set; }
    }
}
