using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using shared.models.configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared.models
{
    public  class DartDbContext : DbContext
    {
        #region Properties
        #region Tables
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        #endregion
        #endregion

        public DartDbContext(DbContextOptions<DartDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApplicationsUserConfiguration());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            // Pre-convention model configuration goes here
            configurationBuilder.Properties<string>().HaveMaxLength(50);    
        }

    }
}
