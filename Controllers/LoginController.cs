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
        public ActionResult Authorize(Customer customerModel)
        {
            var customerDetails = _context.Customers.Where(g => g.Username == customerModel.Username && g.Password == customerModel.Password).FirstOrDefault();

            if(customerDetails == null)
            {
                string noResult = "Wrong user name or password";
                ViewBag.Message = noResult;
                return View("Index", customerDetails);
            }
            else
            {
                Session["userId"] = customerDetails.Id;
                Session["userName"] = customerDetails.Username;
                return RedirectToAction("Index", "Home");
            }
        }

        
        

       


    }
}