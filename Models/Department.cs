using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NLIH.Models
{
    public class Department
    {
        
        public byte Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

    }
}