using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Productos");

            builder.Property(p =>p.Id)
                .IsRequired();

            builder.Property(p=> p.FechaCreacion);

            builder.Property(p=>p.Nombre)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p=>p.Precio)
                .HasColumnType("decimal(10,8)");

            builder.HasOne(p=>p.Marca)
            .WithMany(p=>p.Productos)
            .HasForeignKey(p=>p.MarcaId);

            builder.HasOne(p=>p.Categoria)
            .WithMany(p=>p.Productos)
            .HasForeignKey(p=>p.CategoriaId);
        }
    }
}