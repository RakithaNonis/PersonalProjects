using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demo.Models
{
    public class ViewModel
    {
        public Guest guestList { get; set; }
        public Checkin checkinList { get; set; }

        public Symptom symptomList { get; set; }

        public Temperature temperaturelist { get; set; }

    }
}