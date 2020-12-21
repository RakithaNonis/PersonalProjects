using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demo.Models
{ 
     [MetadataType(typeof(EntranceMetaData))]
    public partial class Entrance
    {
    }
    public class EntranceMetaData 
    {
        [Display(Name = "Guest Entrance type")]

        public int EntranceId { get; set; }
    }
}