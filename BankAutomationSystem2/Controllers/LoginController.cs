using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;
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
        
        public ActionResult Login(User user)
        {
            
            if( !string.IsNullOrWhiteSpace(user.Email) && !string.IsNullOrWhiteSpace(user.Password))
            {

                //bool IsValidUser = dbContext.Users
                //    .SingleOrDefault(u => u.Email.ToLower() == user
                //    .Email.ToLower() && 
                //    u.Password == user.Password);
                var IsValisUser = dbContext.Users.Where(x => x.Email.ToLower() == user.Email.ToLower() && x.Password == user.Password).FirstOrDefault();
                if (IsValisUser != null && IsValisUser.UserId>0)
                {
                    FormsAuthentication.SetAuthCookie(user.Email, false);
                    return RedirectToAction("Details", "Users", new { id = IsValisUser.UserId });
                }

            }
            else
            {
                ModelState.AddModelError("", "invalid UserName and Password");
            }
            
            return View();

        }
        //private bool GetValidUser(LoginController login)
        //{
        //    return dbContext.login
        //        .Any(login.)
        //}
    }
}