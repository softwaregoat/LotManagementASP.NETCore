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
        public IActionResult DataQuery(string Query)
        {
            var Lots = _context.TblDataArchiveQuery.ToList();
            if (Lots != null)
            {
                return Json(Lots);
            }
            return Json("Failed");
        }
    }
}
