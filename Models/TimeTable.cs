using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NLIH.Models
{
    public class TimeTable
    {
        public int Id { get; set; }
        public DateTime CheckingSchedule { get; set; }
        public string ReasonsForChecking { get; set; }

        public Guest Guest { get; set; }
        public Doctor Doctor { get; set; }

    }
}