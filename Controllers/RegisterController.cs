using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLIH.Models;
using System.Data.Entity.Validation;

namespace NLIH.Controllers
{
    public class RegisterController : Controller
    {
        private NLHIDbContenxt _context = new NLHIDbContenxt();
        
        // GET: Register
        
        public ActionResult Register(int id = 0)
        {
            Guest guestModel = new Guest();
            ModelState.Clear();
            return View(guestModel);
        }

    
        public ActionResult SignUp(int id = 0)
        {
            Customer customerModel = new Customer();
            return View(customerModel);            

        }

        [HttpPost]
        public ActionResult SignUp(Customer customerModel)
        {
            var newCustomer = new Customer();

            if(_context.Customers.Any(c => c.Username == customerModel.Username))
            {
                ViewBag.DuplicateMessage = "Username already exist.";
                return View("SignUp", customerModel);
            }

            if (_context.Customers.Any(c => c.Name == customerModel.Name && c.Email == customerModel.Email))
            {
                ViewBag.DuplicateMessage = "User already exist.";
                return View("SignUp", customerModel);
            }

            newCustomer.Name = customerModel.Name;
            newCustomer.Address = customerModel.Address;
            newCustomer.DateOfBirth = customerModel.DateOfBirth;
            newCustomer.Email = customerModel.Email;
            newCustomer.Username = customerModel.Username;
            newCustomer.Password = customerModel.Password;
            newCustomer.ConfirmPassword = customerModel.Password;

            if (customerModel.UserTypeId != 0)
            {
                newCustomer.UserTypeId = customerModel.UserTypeId;
            }
            else
            {
                newCustomer.UserTypeId = 1;
            }


            _context.Users.Add(newCustomer);
            _context.SaveChanges();
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful.";
            return View("SignUp", new Customer());


        }

    }
}