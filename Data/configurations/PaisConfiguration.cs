using produccion.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace produccion.Data.Configurations;
  public class PaisConfiguration : IEntityTypeConfiguration<Pais>
  {
     public void Configure(EntityTypeBuilder<Pais> builder)
    {
         builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("pais");

            builder.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
  }
  }