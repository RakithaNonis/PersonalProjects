using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demo.Models
{
    [MetadataType(typeof(CheckinMetaData))]
    public partial class Checkin
    {
    }
    public class CheckinMetaData
    {
        [Display(Name = "Guest hotel")]
        public string HotelCode { get; set; }


    }
}