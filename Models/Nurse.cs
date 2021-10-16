﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NLIH.Models
{
    public class Nurse : User
    {
        public DateTime JoinedDate { get; set; }
        public string SupervisorName { get; set; }

        public UserType UserType { get; set; }
    }
}