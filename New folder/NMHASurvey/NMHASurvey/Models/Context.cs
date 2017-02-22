using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NMHASurvey.Models
{
    public class NMHASurveyContext : DbContext
    {
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Payer> Payers { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
    }
}