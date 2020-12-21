using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demo.Models
{

    [MetadataType(typeof(CountryMetaData))]
    public partial class Country
    {
    }
    public class CountryMetaData 
    {
        [Display(Name = "Guest Country")]
        public string CountryName { get; set; }
        
        public string CountryCode { get; set; }
    }
}