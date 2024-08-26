using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //Primary Key
using System.Linq;
using System.Web;

namespace ThekwiniEstate.Models
{
    public class Area
    {
        [Key]
        public int AreaCode { get; set; }
        public string AreaName { get; set; }

        public double AreaRate { get; set; }
    }
}