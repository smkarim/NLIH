using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NLIH.Models
{
    public class Doctor : User
    {
        public string Specialization { get; set; }
        public List<String> Degree { get; set; }
        public string ContactNo { get; set; }

        public UserType UserType { get; set; }

        public Department Department { get; set; }


    }
}