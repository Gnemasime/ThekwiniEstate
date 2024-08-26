using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThekwiniEstate.Models
{
    public class Owner
    {
       [Key]
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }

        public int Age { get; set; }
        public int Points { get; set; }
    }
}