using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class EquipeMapping : IEntityTypeConfiguration<EquipeEntity>
    {
        public void Configure(EntityTypeBuilder<EquipeEntity> builder)
        {
            builder.ToTable("Equipe");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();

            builder.Property(x => x.Nome).HasColumnName("Nome").IsRequired().HasMaxLength(50);
            builder.Property(x => x.GerenteId).HasColumnName("GerenteId").IsRequired();
        }
    }
}
