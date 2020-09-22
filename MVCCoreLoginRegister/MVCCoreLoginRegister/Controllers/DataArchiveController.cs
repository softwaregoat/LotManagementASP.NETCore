using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreLoginRegister.Data;

namespace MVCCoreLoginRegister.Controllers
{
    public class DataArchiveController : Controller
    {
        JobBagContext _context = new JobBagContext();
        // GET: DataArchiveController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetLot()
        {
            var Lots = _context.TblLot.ToList();
            if (Lots != null)
            {
                return Json(Lots);
            }
            return Json("Failed");
        }
        [HttpPost]
        public IActionResult GetDataArchiveQuery()
        {
            var Lots = _context.TblDataArchiveQuery.ToList();
            if (Lots != null)
            {
                return Json(Lots);
            }
            return Json("Failed");
        }
        [HttpPost]
        public IActionResult QryLot(int LotID)
        {
            var em = _context.QryLot.SingleOrDefault(em => em.LotId == LotID);
            if (em != null)
            {
                return Json(em);
            }
            return Json("Failed");
        }
        [HttpPost]
        public IActionResult DataQuery(int Query, string Lot)
        {
            switch (Query)
            {
                case 1:
                    return QryLineClearance(Lot);
                case 2:
                    return QryAuthorisation(Lot);
                case 3:
                    return QryProductCheckPoint(Lot);
                case 4:
                    return QryMaterial(Lot);
                case 5:
                    return QryQuality(Lot);
                case 6:
                    return QryCavitation(Lot);
                case 7:
                    return QryMachine(Lot);
                case 8:
                    return QryFunctional(Lot);
                default:
                    break;
            }
            return Json("Failed");
        }
        public IActionResult QryLineClearance(string Lot)
        {
            var ems = _context.QryLineClearanceRecords.Where(e => e.LotName == Lot);
            if (ems != null)
            {
                return Json(ems);
            }
            return Json("Failed");
        }
        public IActionResult QryAuthorisation(string Lot)
        {
            var ems = _context.QryAuthorisationToRunRecords.Where(e => e.LotName == Lot);
            if (ems != null)
            {
                return Json(ems);
            }
            return Json("Failed");
        }

        public IActionResult QryProductCheckPoint(string Lot)
        {
            var ems = _context.QryProductCheckPointData.Where(e => e.LotName == Lot);
            if (ems != null)
            {
                return Json(ems);
            }
            return Json("Failed");
        }

        public IActionResult QryMaterial(string Lot)
        {
            var ems = _context.QryMaterialTraceabilityData.Where(e => e.LotName == Lot);
            if (ems != null)
            {
                return Json(ems);
            }
            return Json("Failed");
        }

        public IActionResult QryQuality(string Lot)
        {
            var ems = _context.QryQualityRecords.Where(e => e.LotName == Lot);
            if (ems != null)
            {
                return Json(ems);
            }
            return Json("Failed");
        }

        public IActionResult QryCavitation(string Lot)
        {
            var ems = _context.QryActiveCavitationRecords.Where(e => e.LotName == Lot);
            if (ems != null)
            {
                return Json(ems);
            }
            return Json("Failed");
        }

        public IActionResult QryMachine(string Lot)
        {
            var ems = _context.QryMachineDowntimeRecords.Where(e => e.LotName == Lot);
            if (ems != null)
            {
                return Json(ems);
            }
            return Json("Failed");
        }

        public IActionResult QryFunctional(string Lot)
        {
            var ems = _context.QryFunctionalTestRecords.Where(e=>e.LotName == Lot);
            if (ems != null)
            {
                return Json(ems);
            }
            return Json("Failed");
        }
    }
}
