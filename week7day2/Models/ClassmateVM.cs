using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using week7day2.Controllers;

namespace week7day2.Models
{
    public class ClassmateVM
    {
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Height { get; set; }
        [Display(Name = "Color of your Hair")]
        public string HairColor { get; set; }
      
    }
   
}