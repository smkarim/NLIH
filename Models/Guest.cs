using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NLIH.Models
{
    public class Guest : User
    {
        [DisplayName("User Name")]
        [Required(ErrorMessage ="This field is mandatory")]
        public string Username { get; set; }

        [Required(ErrorMessage ="This field is mandatory")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public UserType UserType { get; set; }
        [DisplayName("User Type")]
        public byte UserTypeId { get; set; }

    }
}