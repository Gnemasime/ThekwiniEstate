using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ThekwiniEstate.Models
{
    public class ThekwiniDBContext:DbContext
    {
        public ThekwiniDBContext() : base("ThekwiniDB")
        { }

        public DbSet <Area> areas { get; set; }
        public DbSet <Owner> owners { get; set; }
        public DbSet <Violation> violations { get; set; }
        public DbSet<EstatePenalty> estatePenalties { get; set; }



    }
}