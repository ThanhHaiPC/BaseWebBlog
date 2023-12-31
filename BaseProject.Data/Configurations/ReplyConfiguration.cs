﻿using BaseProject.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Data.Configurations
{
    public class ReplyConfiguration : IEntityTypeConfiguration<Reply>
    {
        public void Configure(EntityTypeBuilder<Reply> builder)
        {
            builder.ToTable("Replys");

            builder.HasKey(x => x.ReplyID);
            builder.Property(x => x.Content).IsRequired(false).HasMaxLength(500);


            // Relationship
            builder.HasOne(x => x.User).WithMany(x => x.Reply).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Comment).WithMany(x => x.Replies).HasForeignKey(x => x.CommentID);
        }
    }
}
