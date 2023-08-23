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
    }
}
