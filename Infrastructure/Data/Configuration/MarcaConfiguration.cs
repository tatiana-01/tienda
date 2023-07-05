using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.ToTable("Marcas");

            builder.Property(p =>p.Id)
                .IsRequired();


            builder.Property(p=>p.Nombre)
                .IsRequired()
                .HasMaxLength(100);

        }
    }
}