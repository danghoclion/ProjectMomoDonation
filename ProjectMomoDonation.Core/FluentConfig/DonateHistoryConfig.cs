using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectMomoDonation.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMomoDonation.Core.FluentConfig
{
    public class DonateHistoryConfig : IEntityTypeConfiguration<DonateHistory>
    {
        public void Configure(EntityTypeBuilder<DonateHistory> builder)
        {
            builder.HasKey(x => new { x.Id, x.ProgramDonationId });
            builder.HasOne(x => x.MomoUser).WithMany(pc => pc.DonateHistorys).HasForeignKey(pc => pc.Id);
            builder.HasOne(x => x.ProgramDonation).WithMany(pc => pc.DonateHistorys).HasForeignKey(pc => pc.ProgramDonationId);
        }
    }
}
