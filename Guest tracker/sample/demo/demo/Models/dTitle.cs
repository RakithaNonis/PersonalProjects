using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demo.Models
{
    [MetadataType(typeof(TitleMetaData))]
    public partial class Title
    {
    }
    public class TitleMetaData 
    {
        [Display(Name = "Guest name title")]
        public string TitleName { get; set; }
    }
}