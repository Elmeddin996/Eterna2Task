using EternaAddedPortofilo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TemplateSetupTask.Models;

namespace TemplateSetupTask.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<Service> Services { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
    }
}
