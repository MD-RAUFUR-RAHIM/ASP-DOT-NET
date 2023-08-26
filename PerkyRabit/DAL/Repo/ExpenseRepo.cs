using DAL.EF.Models;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class ExpenseRepo : Repo, IRepo<Expense, int, bool>
    {
        public bool Create(Expense obj)
        {
            db.Expenses.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Expenses.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Expense> Get()
        {
            return db.Expenses.ToList();
        }

        public Expense Get(int id)
        {
            return db.Expenses.Find(id);
        }

        public bool Update(Expense obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
