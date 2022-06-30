using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PubReviews.Data.Data.Models
{
    public class Country
    {
        [Key]
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
    }
}
