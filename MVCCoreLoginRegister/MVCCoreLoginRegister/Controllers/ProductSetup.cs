using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCCoreLoginRegister.Controllers
{
    public class ProductSetup : Controller
    {
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

        // GET: ProductSetup/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductSetup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductSetup/Create
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

        // GET: ProductSetup/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductSetup/Edit/5
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

        // GET: ProductSetup/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductSetup/Delete/5
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
