using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NLIH.Models
{
    public class Treatment
    {
        public int Id { get; set; }
        public List<string> Issue { get; set; }
        public List<string> Medicine { get; set; }
        public List<string> Test { get; set; }

        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }
}