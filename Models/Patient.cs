using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NLIH.Models
{
    public class Patient : User
    {
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Admission Date")]
        public DateTime AdmissionDate { get; set; }
        
        [DisplayName("Release Date")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ? ReleaseDate { get; set; }
        
        
        public byte RoomNo { get; set; }
        public string Issues { get; set; }

        public UserType UserType { get; set; }
        [DisplayName("User Type")]
        public byte UserTypeId { get; set; }
    }
}