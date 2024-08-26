using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //Primary Key
using System.ComponentModel.DataAnnotations.Schema; //Autogeneration
using System.Linq;
using System.Web;

namespace ThekwiniEstate.Models
{
    public class EstatePenalty
    {//1.1
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PenaltyId { get; set; }
        public int OwnerId { get; set; }
        public virtual Owner Owner { get; set; }

        public int AreaCode { get; set; }
        public virtual Area Area { get; set; }

        public int ViolationCode { get; set; }
        public virtual Violation Violation { get; set; }

        public double TotalPenaltyCost { get; set; }

        //1.2.
        //LINQ Language intergrated query

        public double PullViolationCost()
        {
            ThekwiniDBContext database = new ThekwiniDBContext();
            var zh = (from z in database.violations
                      where z.ViolationCode == ViolationCode
                      select z.ViolationCost).FirstOrDefault();
            return zh;
        }

        public double PullAreaRate()
        {
            ThekwiniDBContext db = new ThekwiniDBContext();
            var gj = (from j in db.areas
                      where j.AreaCode == AreaCode
                      select j.AreaRate).FirstOrDefault();
            return gj;
        }
        public double CalcAreaPenaltyCost()
        {
            return PullAreaRate() * PullViolationCost();
        }
    }
}