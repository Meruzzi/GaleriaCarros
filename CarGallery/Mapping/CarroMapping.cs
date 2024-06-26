﻿using GaleriaCarros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GaleriaCarros.Mapping
{
    public class CarroMapping : IEntityTypeConfiguration<Carro>
    {
        public void Configure(EntityTypeBuilder<Carro> builder)
        {

            builder.HasKey(x => x.Id);  
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);
            builder.Property(x => x.DescCurta).IsRequired().HasMaxLength(250);
            builder.Property(x => x.DescCompleta).IsRequired().HasMaxLength(1024);
            builder.Property(x => x.Imagem).IsRequired().HasMaxLength(1024);

        }
    }
}
