using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BankAutomationSystem2.Data;
using BankAutomationSystem2.Models;

namespace BankAutomationSystem2.Controllers
{
    public class LoginController : Controller
    {
        BankAutomationSystemContext dbContext = new BankAutomationSystemContext();
        public ActionResult Login()
        {

            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            
            if (ModelState.IsValid)
            {
                bool IsValidUser = dbContext.Users
                    .Any(u => u.Email.ToLower() == user
                    .Email.ToLower() && user
                    .Password == user.Password);
                if (IsValidUser)
                {
                    FormsAuthentication.SetAuthCookie(user.Email, true);
                    return RedirectToAction("Users", "Index");
                }

            }
            ModelState.AddModelError("", "invalid UserName and Password");
            return View();

        }
    }
}