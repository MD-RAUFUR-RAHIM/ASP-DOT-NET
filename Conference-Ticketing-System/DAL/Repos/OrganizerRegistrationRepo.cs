using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class OrganizerRegistrationRepo : Repo, IRepo<OrganizerRegistration, int, bool>
    {
        public bool Create(OrganizerRegistration obj)
        {
            db.OrganizerRegistrations.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.OrganizerRegistrations.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<OrganizerRegistration> Get()
        {
            return db.OrganizerRegistrations.ToList();
        }

        public OrganizerRegistration Get(int id)
        {
            return db.OrganizerRegistrations.Find(id);
        }

        public bool Update(OrganizerRegistration obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
