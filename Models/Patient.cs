using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NLIH.Models
{
    public class Patient : User
    {
        public DateTime AdmissionDate { get; set; }
        public DateTime ? ReleaseDate { get; set; }
        public byte RoomNo { get; set; }
        public string Issues { get; set; }

        public UserType UserType { get; set; }
    }
}