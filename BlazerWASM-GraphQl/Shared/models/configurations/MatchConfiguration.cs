using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared.models.configurations
{
    public class MatchConfiguration : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            /*
            builder.HasOne(m => m.Player1)
                .WithMany(m => m.Matches)
                .HasForeignKey(m => m.Player1Id)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(m => m.Player2)
                .WithMany(m => m.Matches)
                .HasForeignKey(m => m.Player2Id)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            */

            builder.HasData(new Match
            {
                Id = 1,
                Password = "1234",
                Player1Id = 1,
                Player2Id = 2
            });
        }
    }
}
