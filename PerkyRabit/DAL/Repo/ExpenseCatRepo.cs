using DAL.EF.Models;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class ExpenseCatRepo : Repo, IRepo<ExpenseCat, int, bool>
    {
        public bool Create(ExpenseCat obj)
        {
            db.ExpenseCats.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.ExpenseCats.Remove(ex);
            return db.SaveChanges() > 0;
            
        }

        public List<ExpenseCat> Get()
        {
            return db.ExpenseCats.ToList();
        }

        public ExpenseCat Get(int id)
        {
            return db.ExpenseCats.Find(id);
        }

        public bool Update(ExpenseCat obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
