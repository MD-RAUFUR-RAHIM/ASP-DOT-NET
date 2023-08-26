﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class ExpenseCat
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Expense> Expenses { get; set; }
        public ExpenseCat()
        {
            Expenses = new List<Expense>();
        }
    }
}
