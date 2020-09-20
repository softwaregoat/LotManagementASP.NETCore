using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreLoginRegister.Data;

namespace MVCCoreLoginRegister.Controllers
{
    public class ProductionControlController : Controller
    {
        JobBagContext _context = new JobBagContext();
        // GET: HomeController1
        public ActionResult ProductCheckpoint()
        {
            return View();
        }
        public ActionResult FunctionalTest()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ProductCheckPoint(string Lot)
        {
            //var lines = _context.TblProductCheckPoint.Where(em => em.LotName == Lot);
            var lines = _context.TblProductCheckPoint.ToList();
            if (lines != null)
            {
                return Json(lines);
            }
            return Json("Failed");
        }
        [HttpPost]
        public ActionResult SaveProductCheckPoint(int CartonNo, string Des, string Product, string CheckPoint, bool McRunning, int ActiveCavities,
            string LotName, decimal ShotWeight, int CycleCount, bool Rejects, string PcptimeStamp)
        {
            try
            {
                var em = new TblProductCheckPoint();
                em.CartonNo = CartonNo;
                em.CurrentDate = DateTime.Now;
                em.Des = Des;
                em.ProductName = Product;
                em.CheckPoint = TimeSpan.Parse(CheckPoint);
                em.McRunning = McRunning;
                em.ActiveCavities = ActiveCavities;
                em.ShotWeight = ShotWeight;
                em.CycleCount = CycleCount;
                em.Rejects = Rejects;
                em.LotName = LotName;
                em.PcptimeStamp = Convert.ToDateTime(PcptimeStamp);
                em.LotName = LotName;

                _context.TblProductCheckPoint.Add(em);
                _context.SaveChanges();
                return Json("Success to save");
            }
            catch (Exception)
            {
                return Json("Failed");
            }
        }
        [HttpPost]
        public ActionResult FunctionalTest(string Lot)
        {
            //var lines = _context.TblFunctionalTest.Where(em => em.LotName == Lot);
            var lines = _context.TblFunctionalTest.ToList();
            if (lines != null)
            {
                return Json(lines);
            }
            return Json("Failed");
        }
        [HttpPost]
        public ActionResult FunctionalTestType()
        {
            var lines = _context.TblFunctionalTestType.ToList();
            if (lines != null)
            {
                return Json(lines);
            }
            return Json("Failed");
        }
        [HttpPost]
        public ActionResult FunctionalTestResult()
        {
            var lines = _context.TblFunctionalTestResult.ToList();
            if (lines != null)
            {
                return Json(lines);
            }
            return Json("Failed");
        }
        [HttpPost]
        public ActionResult SaveFunctionalTest(int CartonNo, string Comment, string Des, string FttimeStamp,
            string LotName, string Product, string Result, int SampleSize, string TestType)
        {
            try
            {
                var em = new TblFunctionalTest();
                em.CartonNo = CartonNo;
                em.Comment = Comment;
                em.CurrentDate = DateTime.Now;
                em.Des = Des;
                em.FttimeStamp = Convert.ToDateTime(FttimeStamp);
                em.LotName = LotName;
                em.ProductName = Product;
                em.Result = Result;
                em.SampleSize = SampleSize;
                em.TestType = TestType;

                _context.TblFunctionalTest.Add(em);
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
