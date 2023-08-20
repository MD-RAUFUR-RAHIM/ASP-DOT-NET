using Intro.EF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Intro.EF
{
    public class UMSContext:DbContext
    {
        public DbSet <Teacher> Teachers { get; set; }
    }
}