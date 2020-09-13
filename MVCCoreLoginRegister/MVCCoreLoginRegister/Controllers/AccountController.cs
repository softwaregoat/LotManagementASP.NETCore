using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCCoreLoginRegister.Models;
using MVCCoreLoginRegister.Data;

namespace MVCCoreLoginRegister.Controllers
{
    public class AccountController : Controller
    {
        readonly JobBagContext _context = new JobBagContext();
        // GET: AccountController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return View(userModel);
            }
            var user = _context.TblUser.SingleOrDefault(u => (u.Username == userModel.Username 
               && u.Password == userModel.Password) || u.Rfid == userModel.Rfid
               );
            if (user != null)
            {
                user.LastLoginDate = DateTime.Now;
                user.Active = true;
                _context.SaveChanges();
                //set the key value in Cookie  Username
                Set("Username", user.Username, 60);
                Set("Useremail", user.Email, 60);
                return RedirectToAction(nameof(HomeController.JobBagOverview), "Home");
            }
            else
            {
                ModelState.AddModelError("", "Invalid Username, Rfid or Password");
                return View();
            }
        }
        [HttpPost]
        public ActionResult Logout()
        {
            var email = Get("Useremail");
            var user = _context.TblUser.SingleOrDefault(u => u.Email == email);
            user.Active = false;
            _context.SaveChanges();
            Remove("Username");
            Remove("Useremail");
            return RedirectToAction("Login");
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterModel registerModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                TblUser tblUser = new TblUser();
                tblUser.Email = registerModel.Email;
                tblUser.Rfid = registerModel.Rfid;
                tblUser.Username = registerModel.Username;
                tblUser.Password = registerModel.Password;
                _context.TblUser.Add(tblUser);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Register Error", "Failed. Error:" + ex.ToString());
                return View();
            }
        }
        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountController/Create
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

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
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

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
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
        public void Set(string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();

            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddMilliseconds(10);

            Response.Cookies.Append(key, value, option);
        }
        public void Remove(string key)
        {
            Response.Cookies.Delete(key);
        }
        public string Get(string key)
        {
            return Request.Cookies[key];
        }
    }
}
