using produccion.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace produccion.Data.Configurations;
  public class TipoEstadoConfiguration : IEntityTypeConfiguration<TipoEstado>
  {
     public void Configure(EntityTypeBuilder<TipoEstado> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("tipo_estado");

            builder.Property(e => e.Descripcion).HasMaxLength(50);
  }
  }