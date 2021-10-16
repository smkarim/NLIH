using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NLIH.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        
        //public UserType UserType { get; set; }
        
       // public int UserTypeId { get; set; }
    }
}