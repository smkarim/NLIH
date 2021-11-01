using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLIH.Models;

namespace NLIH.Controllers
{
    public class LoginController : Controller
    {
        private NLHIDbContenxt _context = new NLHIDbContenxt();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorize(Guest guestModel)
        {
            var guestDetails = _context.Guests.Where(g => g.Username == guestModel.Username && g.Password == guestModel.Password).FirstOrDefault();

            if(guestDetails == null)
            {
                string noResult = "Wrong user name or password";
                ViewBag.Message = noResult;
                return View("Index",guestDetails);
            }
            else
            {
                Session["userId"] = guestDetails.Id;
                Session["userName"] = guestDetails.Username;
                return RedirectToAction("Index", "Home");
            }
        }



    }
}