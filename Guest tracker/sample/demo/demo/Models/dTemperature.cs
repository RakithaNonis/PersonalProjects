using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demo.Models
{
    [MetadataType(typeof(TemperatureMetaData))]
    public partial class Temperature
    {
    }
    
    public class TemperatureMetaData 
    {
        //[Required]
        //public Nullable<bool> TableNumber { get; set; }
        //public Nullable<bool> TemperatureValue { get; set; }
    }
}