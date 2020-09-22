using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using MVCCoreLoginRegister.Data;

namespace MVCCoreLoginRegister.Controllers
{
    public class SupportingDocController : Controller
    {
        JobBagContext _context = new JobBagContext();
        // GET: SupportingDocController
        public ActionResult ProductDrawing()
        {
            return View();
        }
        public ActionResult ProductQISheet()
        {
            return View();
        }
        public ActionResult PackingSpec()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ProductDrawing(string Product)
        {
            var em = _context.TblProduct.SingleOrDefault(em => em.ProductName == Product);
            if (em!=null)
            {
                return Json(em);
            }
            return Json("Failed");
        }
    }
}
