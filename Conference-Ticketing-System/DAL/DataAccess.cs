using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        public static IRepo<Conference, int, bool> ConferenceData()
        {
            return new ConferenceRepo();
        }
        public static IRepo<OrganizerRegistration, int, bool> OrganizerRegistrationData()
        {
            return new OrganizerRegistrationRepo();
        }
        public static IRepo<Auditorium, int, bool> AuditoriumData()
        {
            return new AuditoriumRepo();
        }
        public static IRepo<Venue, int, bool> VenueData()
        {
            return new VenueRepo();
        }
        public static IRepo<Sponsorship, int , bool> SponsorshipData()
        {
            return new SponsorshipRepo();
        }
        public static IRepo<TokenOrganizer, int , TokenOrganizer>TokenOrganizerData()
        {
            return new TokenRepo();
        }
        public static IAuth AuthDataAccess()
        {
            return new OrganizerRegistrationRepo();
        }
    }
}
