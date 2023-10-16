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
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");

            builder.HasKey(x => x.CommentID);
            builder.Property(x => x.Content).IsRequired().HasMaxLength(2000);



            // Relationship
            builder.HasOne(x => x.User).WithMany(x => x.Comment).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Post).WithMany(x => x.Comment).HasForeignKey(x => x.PostID);
        }
    }
}
