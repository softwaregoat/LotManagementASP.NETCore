using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreLoginRegister.Data;

namespace MVCCoreLoginRegister.Controllers
{
    public class ProductSetupController : Controller
    {
        JobBagContext _context = new JobBagContext();
        // GET: ProductSetup
        public ActionResult LineClearance()
        {
            return View();
        }
        public ActionResult Authorisation()
        {
            return View();
        }
        public ActionResult MaterialLot()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LineClearance(string Lot)
        {
            var lines = _context.TblLineClearance.Where(em => em.LotName == Lot);
            //var lines = _context.TblLineClearance.ToList();
            if (lines!=null)
            {
                return Json(lines);
            }
            return Json("Failed");
        }
        [HttpPost]
        public ActionResult SaveLineClearance(string LCTimeStamp, string TechRFID, string TechUsername, string QCRFID, string QCUsername, string LotName)
        {
            try
            {
                var line = new TblLineClearance();
                line.CurrentDate = DateTime.Now;
                line.LctimeStamp = Convert.ToDateTime(LCTimeStamp);
                line.TechRfid = TechRFID;
                line.TechUsername = TechUsername;
                line.Qcrfid = QCRFID;
                line.Qcusername = QCUsername;
                line.LotName = LotName;
                _context.TblLineClearance.Add(line);
                _context.SaveChanges();
                return Json("Success to save");
            }
            catch (Exception)
            {
                return Json("Failed");
            }
        }
        [HttpPost]
        public ActionResult AuthorisationToRun(string Lot)
        {
            //var lines = _context.TblAuthorisationToRun.Where(em => em.LotName == Lot);
            var lines = _context.TblAuthorisationToRun.ToList();
            if (lines != null)
            {
                return Json(lines);
            }
            return Json("Failed");
        }
        [HttpPost]
        public ActionResult SaveAuthorisationToRun(string LCTimeStamp, string TechRFID, string TechUsername, string QCRFID, string QCUsername, string LotName)
        {
            try
            {
                var em = new TblAuthorisationToRun();
                em.CurrentDate = DateTime.Now;
                em.AtrtimeStamp = Convert.ToDateTime(LCTimeStamp);
                em.TechRfid = TechRFID;
                em.TechUsername = TechUsername;
                em.Qcrfid = QCRFID;
                em.Qcusername = QCUsername;
                em.LotName = LotName;
                _context.TblAuthorisationToRun.Add(em);
                _context.SaveChanges();
                return Json("Success to save");
            }
            catch (Exception)
            {
                return Json("Failed");
            }
        }
        [HttpPost]
        public ActionResult MaterialLot(string Lot)
        {
            //var lines = _context.TblMaterialLotControl.Where(em => em.LotName == Lot);
            var lines = _context.TblMaterialLotControl.ToList();
            if (lines != null)
            {
                return Json(lines);
            }
            return Json("Failed");
        }
        [HttpPost]
        public ActionResult SaveMaterialLot(int CartonNo, string P1lot, string P2lot, string Mblot, string Salot, string Mlctimestamp, string LotName, string Des)
        {
            try
            {
                var em = new TblMaterialLotControl();
                em.CartonNo = CartonNo;
                em.CurrentDate = DateTime.Now;
                em.P1lot = P1lot;
                em.P2lot = P2lot;
                em.Mblot = Mblot;
                em.Salot = Salot;
                em.LotName = LotName;
                em.MlctimeStamp = Convert.ToDateTime(Mlctimestamp);
                em.LotName = LotName;
                em.Des = Des;
                _context.TblMaterialLotControl.Add(em);
                _context.SaveChanges();
                return Json("Success to save");
            }
            catch (Exception)
            {
                return Json("Failed");
            }
        }
    }
}
