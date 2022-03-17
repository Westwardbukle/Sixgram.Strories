using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sixgram.Stories.Database.Models;

namespace Sixgram.Stories.Database.TablesConfiguration
{
    public class StoryModelConfiguration: IEntityTypeConfiguration<StoryModel>
    {
        public void Configure(EntityTypeBuilder<StoryModel> builder)
        {
            builder.Property(s => s.DateCreated).HasColumnType("timestamp without time zone").IsRequired();
            builder.Property(s => s.Name).IsRequired().HasMaxLength(50);
            builder.Property(s => s.Description).IsRequired().HasMaxLength(100);
            builder.Property(s => s.UserId).IsRequired().HasMaxLength(50);
        }
    }
}