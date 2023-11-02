using produccion.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace produccion.Data.Configurations;
  public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
  {
     public void Configure(EntityTypeBuilder<Genero> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("genero");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
  }
  }