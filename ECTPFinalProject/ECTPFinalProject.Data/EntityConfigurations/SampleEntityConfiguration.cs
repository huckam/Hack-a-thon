using Microsoft.EntityFrameworkCore;
using ECTPFinalProject.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECTPFinalProject.Data.EntityConfigurations
{
    public class SampleEntityConfiguration : IEntityTypeConfiguration<SampleEntity>
    {
        public void Configure(EntityTypeBuilder<SampleEntity> builder)
        {
            //TODO: Add configurations that define primary keys, relationships between other entities, any restrictions on properties

            //builder.HasKey(x => x.SampleEntityId).HasName("PK_SampleEntity");

            //TODO: Provide sampel data by seeding the database

            /*builder.HasData(
                new SampleEntity { ..... },
                new SampleEntity { ..... }
            );*/
        }
    }
}
