using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demo.Models
{
    public partial class Symptom
    {
        public bool IsCheked { get; set; }
    }
    public class SymptomModel
    {
        public List<Symptom> symptomslist { get; set; }
    }
}