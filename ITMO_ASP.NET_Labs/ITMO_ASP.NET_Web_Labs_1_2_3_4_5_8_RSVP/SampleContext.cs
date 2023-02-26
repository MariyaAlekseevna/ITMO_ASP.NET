using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using static ITMO_ASP.NET_Web_Labs_1_2_3_4_5_8_RSVP.GuestResponse;

namespace ITMO_ASP.NET_Web_Labs_1_2_3_4_5_8_RSVP
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("SeminarBD") { }
        public DbSet<GuestResponse> GuestResponses { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}