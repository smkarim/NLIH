using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NLIH.Models
{
    public class Staff : User
    {
        public List<string> Certificates { get; set; }
        public DateTime  JoinedDate { get; set; }
        public bool IsActive { get; set; }

        public UserType UserType { get; set; }
    }
}