using MVCCoreLoginRegister.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreLoginRegister.Models
{
    public class JobBagOverview
    {
        public List<TblTechnology> Technologies { get; set; }
        public List<TblMachine> Machines { get; set; }
        public List<TblLot> Lots { get; set; }

    }
}
