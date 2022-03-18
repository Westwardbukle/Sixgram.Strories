using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sixgram.Stories.Database.Models;

namespace Sixgram.Stories.Database.TablesConfiguration
{
    public class StoryModelConfiguration : IEntityTypeConfiguration<StoryModel>
    {
        public void Configure(EntityTypeBuilder<StoryModel> builder)
        {
            builder.Property(s => s.DateCreated).HasColumnType("timestamp without time zone").IsRequired();
            builder.Property(s => s.Name).IsRequired().HasMaxLength(50);
            builder.Property(s => s.Description).IsRequired().HasMaxLength(100);
            builder.Property(s => s.UserId).IsRequired().HasMaxLength(50);

            builder.HasData(
                new StoryModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "FirstStory",
                    UserId = Guid.NewGuid(),
                    Description = "Description",
                    FileId = Guid.NewGuid(),
                    DateCreated = DateTime.Now
                },
                new StoryModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "SecondStory",
                    UserId = Guid.NewGuid(),
                    Description = "Description",
                    FileId = Guid.NewGuid(),
                    DateCreated = DateTime.Now
                }
            );
        }
    }
}