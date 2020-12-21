 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demo.Models
{
    [MetadataType(typeof(GuestMetaData))]
    public partial class Guest
    {
    }
    public class GuestMetaData
    {
        [Required]
        [Display(Name = "Guest Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Guest Phone number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Guest Registration Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime RegistrationDate { get; set; }


    }
}