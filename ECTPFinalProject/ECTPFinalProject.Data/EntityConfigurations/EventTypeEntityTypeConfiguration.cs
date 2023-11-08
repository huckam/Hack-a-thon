using Microsoft.EntityFrameworkCore;
using ECTPFinalProject.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECTPFinalProject.Data.EntityConfigurations
{
    public class EventTypeEntityTypeConfiguration : IEntityTypeConfiguration<EventType>
    {
        public void Configure(EntityTypeBuilder<EventType> builder)
        {
            //TODO: Add configurations that define primary keys, relationships between other entities, any restrictions on properties

            //builder.HasKey(x => x.SampleEntityId).HasName("PK_SampleEntity");

            builder.HasKey(x => x.Id);

            //TODO: Provide sampel data by seeding the database

            builder.HasData(new[]
            {
                new EventType {Id = 1, Name = "Mike", Description = "Wolfe"}
            });
        }
    }
}
