using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PubReviews.Data.Data.Models
{
    public class Hotel
    {
        [Key]
        public string HotelCode { get; set; }
        public string HotelName { get; set; }
        public decimal PricePerDaya { get; set; }
    }
}
