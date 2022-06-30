using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PubReviews.Data.Data.Models
{
    public class Gender
    {
        [Key]
        public int GenderId { get; set; }
        public string GenderName { get; set; }
    }
}
