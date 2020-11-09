using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LayoutView.Models
{
    public class CampusContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}