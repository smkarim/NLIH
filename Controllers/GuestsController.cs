using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLIH.Models;
using NLIH.ViewModels;
    using System.Data.Entity;

namespace NLIH.Controllers
{
    public class GuestsController : Controller
    {
        private NLHIDbContenxt _context = new NLHIDbContenxt();
        
       

        public GuestsController()
        {
            //_context.Guests.Include(g => g.UserTypeId). = 1;
            
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();            
        }

        // GET: Guests
        public ActionResult Index()
        {
            var guests = _context.Guests.ToList();
            return View(guests);
        }
    }
}