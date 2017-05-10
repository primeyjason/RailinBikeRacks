using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RailinBikeRacks.WEB.Models
{
    public class ContactUsModel
    {
       
        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        
        public string Phone { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Request")]
        public string Request { get; set; }

    }
}