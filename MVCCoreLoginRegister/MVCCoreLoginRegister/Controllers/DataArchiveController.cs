using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCCoreLoginRegister.Controllers
{
    public class DataArchiveController : Controller
    {
        // GET: DataArchiveController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DataArchiveController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DataArchiveController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DataArchiveController/Create
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

        // GET: DataArchiveController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DataArchiveController/Edit/5
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

        // GET: DataArchiveController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DataArchiveController/Delete/5
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
