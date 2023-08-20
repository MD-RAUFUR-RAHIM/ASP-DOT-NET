using DAL.EF.Models;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class ConferenceRepo : Repo, IRepo<Conference, int, bool>
    {
        public bool Create(Conference obj)
        {
            db.AddConferences.Add(obj);
            return db.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var ex = Get(id);
            db.AddConferences.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Conference> Get()
        {
            return db.AddConferences.ToList();
        }

        public Conference Get(DateTime date)
        {
            var data = (from i in db.AddConferences
                        where i.Date == date
                        select i).SingleOrDefault();
            return data;
        }
        public Conference Get(int id)
        {
            return db.AddConferences.Find(id);
        }
        public bool Update(Conference obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }

       
    }
}
