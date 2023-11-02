using produccion.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace produccion.Data.Configurations;
  public class TipoProteccionConfiguration : IEntityTypeConfiguration<TipoProteccion>
  {
     public void Configure(EntityTypeBuilder<TipoProteccion> builder)
    {
         builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("tipo_proteccion");

            builder.Property(e => e.Descripcion).HasMaxLength(50);
  }
  }