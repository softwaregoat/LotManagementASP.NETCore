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
        public IActionResult DataQuery(int Query)
        {
            switch (Query)
            {
                case 1:
                    return QryLineClearance();
                case 2:
                    return QryAuthorisation();
                case 3:
                    return QryProductCheckPoint();
                case 4:
                    return QryMaterial();
                case 5:
                    return QryQuality();
                case 6:
                    return QryCavitation();
                case 7:
                    return QryMachine();
                case 8:
                    return QryFunctional();
                default:
                    break;
            }
            return Json("Failed");
        }
        public IActionResult QryLineClearance()
        {
            var ems = _context.QryLineClearanceRecords.ToList();
            if (ems != null)
            {
                return Json(ems);
            }
            return Json("Failed");
        }
        public IActionResult QryAuthorisation()
        {
            var ems = _context.QryAuthorisationToRunRecords.ToList();
            if (ems != null)
            {
                return Json(ems);
            }
            return Json("Failed");
        }

        public IActionResult QryProductCheckPoint()
        {
            var ems = _context.QryProductCheckPointData.ToList();
            if (ems != null)
            {
                return Json(ems);
            }
            return Json("Failed");
        }

        public IActionResult QryMaterial()
        {
            var ems = _context.QryMaterialTraceabilityData.ToList();
            if (ems != null)
            {
                return Json(ems);
            }
            return Json("Failed");
        }

        public IActionResult QryQuality()
        {
            var ems = _context.QryQualityRecords.ToList();
            if (ems != null)
            {
                return Json(ems);
            }
            return Json("Failed");
        }

        public IActionResult QryCavitation()
        {
            var ems = _context.QryActiveCavitationRecords.ToList();
            if (ems != null)
            {
                return Json(ems);
            }
            return Json("Failed");
        }

        public IActionResult QryMachine()
        {
            var ems = _context.QryMachineDowntimeRecords.ToList();
            if (ems != null)
            {
                return Json(ems);
            }
            return Json("Failed");
        }

        public IActionResult QryFunctional()
        {
            var ems = _context.QryFunctionalTestRecords.ToList();
            if (ems != null)
            {
                return Json(ems);
            }
            return Json("Failed");
        }
    }
}
