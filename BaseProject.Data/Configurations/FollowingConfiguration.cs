using BaseProject.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Data.Configurations
{
    public class FollowingConfiguration : IEntityTypeConfiguration<Follow>
    {
        public void Configure(EntityTypeBuilder<Follow> builder)
        {
            builder.ToTable("Followings");

            builder.HasKey(x => new { x.FollowerId, x.FolloweeId });


            // RelationShip 1 -n
            builder.HasOne(x => x.Follower).WithMany(x => x.Followee).HasForeignKey(x => x.FollowerId);

        }
    }
}
