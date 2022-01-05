using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared.models.configurations
{
    public class ApplicationsUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(
                new ApplicationUser
                {
                    Id = 1,
                    Name = "Wannes Rebry",
                    Email = "Wannes.Rebry@noest.it"
                }, new ApplicationUser
                {
                    Id = 2,
                    Name = "iemand",
                    Email = "iemand@noest.it"
                });

        }
    }
}
