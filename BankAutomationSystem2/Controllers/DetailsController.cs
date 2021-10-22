using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BankAutomationSystem2.Data;
using BankAutomationSystem2.Models;

namespace BankAutomationSystem2.Controllers
{
    public class DetailsController : Controller
    {
        BankAutomationSystemContext db = new BankAutomationSystemContext();
        // GET: Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }
    }
}