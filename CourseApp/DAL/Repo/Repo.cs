﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class Repo
    {
        protected CourseContext db;
        protected Repo()
        {
            db = new CourseContext();
        }
    }
}
