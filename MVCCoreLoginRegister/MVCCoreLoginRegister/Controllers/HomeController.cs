using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCCoreLoginRegister.Data;
using MVCCoreLoginRegister.Models;

namespace MVCCoreLoginRegister.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        JobBagContext _context = new JobBagContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CavitationRecord()
        {
            return View();
        }
        public IActionResult MachineDowntimeRecord()
        {
            return View();
        }
        public IActionResult QualityRecord()
        {
            return View();
        }
        public IActionResult JobBagOverview()
        {
            JobBagOverview jobBagOverview = new JobBagOverview();
            jobBagOverview.Lots = _context.TblLot.ToList();
            jobBagOverview.Machines = _context.TblMachine.ToList();
            jobBagOverview.Technologies = _context.TblTechnology.ToList();

            return View(jobBagOverview);
        }
        [HttpPost]
        public IActionResult QryLot(string Technology, string Machine, string Lot)
        {
            var qryLot = _context.QryLot.SingleOrDefault(q => q.MachineName == Machine && q.LotName == Lot && q.TechnologyName == Technology);
            if (qryLot != null)
            {
                return Json(qryLot);
            }
            return Json("Failed");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
