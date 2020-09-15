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
        // GET: AccountController/password
        public ActionResult Password()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Password(string Password)
        {
            if (Password == "admin")
            {
                return Json("Success");
            }
            return Json("Failed");
        }
        [HttpPost]
        public ActionResult GetUser(string TechRfid)
        {
            var user = _context.TblUser.SingleOrDefault(u => u.Rfid == TechRfid);
            if (user != null)
            {
                return Json(user);
            }
            return Json("Failed");
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
