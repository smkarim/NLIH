using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLIH.Models;

namespace NLIH.ViewModels
{
    public class GuestViewModel
    {
        public User User { get; set; }
        public Guest Guest { get; set; }
    }
}