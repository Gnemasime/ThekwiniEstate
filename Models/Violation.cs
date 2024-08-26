using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThekwiniEstate.Models
{
    public class Violation
    {
        [Key]
        public int ViolationCode { get; set; }
        public string VilationName { get; set; }

        public double ViolationCost { get; set; }
    }
}