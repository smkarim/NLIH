using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NLIH.Models
{
    public abstract class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is mandatory")]
        public string Address { get; set; }

        [DisplayName("Date of Birth")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        
        //public UserType UserType { get; set; }
        
       // public int UserTypeId { get; set; }
    }
}