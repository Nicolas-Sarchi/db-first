using produccion.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace produccion.Data.Configurations;
  public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
  {
     public void Configure(EntityTypeBuilder<TipoPersona> builder)
    {
         builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("tipo_persona");

            builder.Property(e => e.Nombre).HasMaxLength(50);
  }
  }