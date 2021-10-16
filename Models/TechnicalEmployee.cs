using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NLIH.Models
{
    public class TechnicalEmployee : User
    {
        public string Designation { get; set; }
        public string LastExperiance { get; set; }
        public DateTime JoinedDate { get; set; }

        public UserType UserType { get; set; }
    }
}