using PubReviews.Data.Context;
using PubReviews.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PubReviews.Data.Data
{
    public class DBInitialiser
    {
        public static void Seed(PubReviewsContext context) 
        {
            if (!context.Guests.Any())
            {
                context.Guests.Add
                    (
                    new Guest { GuestName = "Rakitha", PhoneNumber = "714705634", Address = "Moratuwa", CountryCode = " EGY", EmailAddress = "Rakitha.Nonis@inivossl.com", HotelCode = "BEY", GenderId = 1, NumofDays = 1, CheckinDate = DateTime.Now, TotalBill = 100 }
                    );
                context.Guests.Add
                    (
                    new Guest { GuestName = "Sanadi", PhoneNumber = "773741111", Address = "Rawatawatte", CountryCode = " EGY", EmailAddress = "Sanadi.Nonis@inivossl.com", HotelCode = "TRZ", GenderId = 2, NumofDays = 1, CheckinDate = DateTime.Now, TotalBill = 100 }
                    );
                context.Guests.Add
                    (
                    new Guest { GuestName = "Ramiru", PhoneNumber = "174529874", Address = "Dehiwala", CountryCode = " FRA", EmailAddress = "Ramiru.Nonis@inivossl.com", HotelCode = "WLD", GenderId = 1, NumofDays = 1, CheckinDate = DateTime.Now, TotalBill = 100 }
                    );
                context.Guests.Add
                    (
                    new Guest { GuestName = "kaushika", PhoneNumber = "0712328374", Address = "Panadura", CountryCode = " AUS", EmailAddress = "kaushika@inivossl.com", HotelCode = "TRZ", GenderId = 1, NumofDays = 1, CheckinDate = DateTime.Now, TotalBill = 100 }
                    );
            }
            context.SaveChanges();
        }
    }
}
