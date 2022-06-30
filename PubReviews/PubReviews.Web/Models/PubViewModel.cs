using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PubReviews.Web.Models
{
    public class PubViewModel
    {
        public int GuestId { get; set; }
        public string GuestName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string CountryCode { get; set; }
        public string EmailAddress { get; set; }
        public string HotelCode { get; set; }
        public int GenderId { get; set; }
        public int NumofDays { get; set; }
        public DateTime CheckinDate { get; set; }
    }
}
