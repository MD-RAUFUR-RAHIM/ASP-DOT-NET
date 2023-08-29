using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class CTSContext: DbContext

    {
        public DbSet<OrganizerRegistration> OrganizerRegistrations { get; set; }
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<Venue> Venues { get; set;}
        public DbSet<Auditorium> Auditoriums { get; set; }
        public DbSet<Sponsorship> Sponsorships { get; set;}
        public DbSet<TokenOrganizer> TokenOrganizers { get; set; }
    }
}
