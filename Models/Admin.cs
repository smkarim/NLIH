using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NLIH.Models
{
    public class Admin : User
    {
        public DateTime JoinedDate { get; set; }
        public string LastExperiance { get; set; }

        public UserType UserType { get; set; }
    }
}