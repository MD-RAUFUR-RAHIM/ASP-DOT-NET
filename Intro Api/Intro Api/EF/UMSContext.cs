using Intro_Api.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Intro_Api.EF
{
    public class UMSContext:DbContext
    {
        public DbSet <Teacher> Teachers { get; set; }
    }
}