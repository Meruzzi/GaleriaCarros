
using GaleriaCarros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GaleriaCarros.Mapping
{
    public class FabricanteMapping : IEntityTypeConfiguration<Fabricante>
    {
        public void Configure(EntityTypeBuilder<Fabricante> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Nome).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Descricao).HasMaxLength(1024);

        }
    }
}
