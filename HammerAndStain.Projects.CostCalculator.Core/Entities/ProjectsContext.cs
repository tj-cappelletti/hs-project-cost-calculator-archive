using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace HammerAndStain.Projects.CostCalculator.Core.Entities
{
    public class ProjectsContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(ConfigurationManager.ConnectionStrings["ProjectsContext"].ConnectionString);
    }
}
