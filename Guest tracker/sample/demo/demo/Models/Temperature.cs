//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Temperature
    {
        public int TemperatureId { get; set; }
        public Nullable<bool> TableNumber { get; set; }
        public Nullable<bool> TemperatureValue { get; set; }
        public int CheckinId { get; set; }
    
        public virtual Checkin Checkin { get; set; }
    }
}
