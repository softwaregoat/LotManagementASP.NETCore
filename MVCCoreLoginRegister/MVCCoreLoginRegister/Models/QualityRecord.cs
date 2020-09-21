using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreLoginRegister.Models
{
    public class QualityRecord
    {
        public string LotName { get; set; }
        public string PcptimeStamp { get; set; }
        public string Cav { get; set; }
        public int CavityId { get; set; }
        public string Observation { get; set; }
        public string Action { get; set; }
    }
}
