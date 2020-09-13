using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace MVCCoreLoginRegister.Controllers
{
    public class SupportingDocController : Controller
    {
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
        // GET: SupportingDocController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SupportingDocController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SupportingDocController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SupportingDocController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SupportingDocController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SupportingDocController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SupportingDocController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
