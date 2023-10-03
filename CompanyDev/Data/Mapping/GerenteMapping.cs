using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class GerenteMapping : IEntityTypeConfiguration<GerenteEntity>
    {
        public void Configure(EntityTypeBuilder<GerenteEntity> builder)
        {
            builder.ToTable("Gerente");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();

            builder.Property(x => x.Nome).HasColumnName("Nome").IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).HasColumnName("Email").IsRequired().HasMaxLength(50);
            builder.Property(x => x.Telefone).HasColumnName("Telefone").IsRequired().HasMaxLength(20);
            builder.Property(x => x.Idade).HasColumnName("Idade").IsRequired();
            builder.Property(x => x.Cpf).HasColumnName("Cpf").IsRequired().HasMaxLength(15);
            builder.Property(x => x.EquipeId).HasColumnName("EquipeId").IsRequired();
        }
    }
}
