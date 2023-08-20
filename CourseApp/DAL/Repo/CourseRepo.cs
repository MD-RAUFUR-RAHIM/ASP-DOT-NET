using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class CourseRepo : Repo, IRepo<Course, int, bool>
    {
        public bool Create(Course obj)
        {
            db.Courses.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var exobj = Get(id);
            db.Courses.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<Course> Get()
        {
            return db.Courses.ToList();
        }

        public Course Get(int id)
        {
            return db.Courses.Find(id);
        }

        public bool Update(Course obj)
        {
            throw new NotImplementedException();
        }
    }
}
