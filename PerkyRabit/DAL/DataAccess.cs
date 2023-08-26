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
    public class DataAccess
    {
        public static IRepo<Expense, int, bool> ExpenseData()
        {
            return new ExpenseRepo();
        }
        public static IRepo<ExpenseCat, int, bool> ExpenseCatData()
        {
            return new ExpenseCatRepo();
        }
    }
}
