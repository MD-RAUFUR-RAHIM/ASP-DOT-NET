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
    }
}
