using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NLIH.Models
{
    public class Guest : User
    {
       


        public string Username { get; set; }
        public string Password { get; set; }

        public UserType UserType { get; set; }
    }
}