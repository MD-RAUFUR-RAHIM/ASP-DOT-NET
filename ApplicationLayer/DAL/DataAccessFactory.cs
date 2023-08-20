using DAL.EF.Models;
using DAL.Interface;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Conference, int, bool> AddConferenceData()
        {
            return new ConferenceRepo();
        }
        public static IRepo<OrganizerRegistration, int, bool> OrganizerRegistrationData()
        {
            return new OrganizerRegistrationRepo();
        }
    }
}
