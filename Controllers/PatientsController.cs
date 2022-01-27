using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLIH.Models;

namespace NLIH.Controllers
{
    public class PatientsController : Controller
    {
        private NLHIDbContenxt _context = new NLHIDbContenxt();

        // GET: Patients
        public ActionResult Index()
        {
            var patients = _context.Patients.ToList();
            return View(patients);
        }

        public ActionResult New()
        {
            Patient patientModel = new Patient(); 
            return View(patientModel);            
        }

        [HttpPost]
        public ActionResult Create(Patient patientModel)
        {
            var newPatient = new Patient();

            newPatient.Name = patientModel.Name;
            newPatient.Address = patientModel.Address;
            newPatient.DateOfBirth = patientModel.DateOfBirth;
            newPatient.Email = patientModel.Email;
            newPatient.AdmissionDate = patientModel.AdmissionDate;
            newPatient.ReleaseDate = patientModel.ReleaseDate;
            newPatient.RoomNo = patientModel.RoomNo;
            newPatient.Issues = patientModel.Issues;
            newPatient.UserTypeId = 3;

            _context.Patients.Add(newPatient);
            _context.SaveChanges();
            ModelState.Clear();
            ViewBag.SuccessMessage = "New patient added successful.";
            return View("New", new Patient());            
        }

        //[HttpGet]
        public ActionResult Search(string searchtxt)
        {
            var result = _context.Patients.Where(x => x.Name.Contains(searchtxt));

            return View("Index",result);
        }

    }
}