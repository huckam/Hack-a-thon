using Microsoft.EntityFrameworkCore;
using ECTPFinalProject.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECTPFinalProject.Data.EntityConfigurations
{
    public class EventEntityTypeConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            //TODO: Add configurations that define primary keys, relationships between other entities, any restrictions on properties

            //builder.HasKey(x => x.SampleEntityId).HasName("PK_SampleEntity");

            builder.HasKey(x => x.Id);

            //TODO: Provide sampel data by seeding the database

            builder.HasData(new[]
            {
                new Event 
                {
                    Id = 1, 
                    Description="Hi", 
                    Type = new EventType{ Name="Hi", Description = "Hi"}, 
                    DateCreated = new DateTime(2021, 7, 1, 0, 0, 0, DateTimeKind.Utc), 
                    DateDeleted = new DateTime(2021, 7, 1, 0, 0, 0, DateTimeKind.Utc), 
                    DateUpdated = new DateTime(2021, 7, 1, 0, 0, 0, DateTimeKind.Utc)}
            });
        }
    }
}
