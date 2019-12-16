

using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {

        public ProdutoConfiguration()
        {
            HasKey(x => x.ProdutoId);

            Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(250);

            Property(x => x.Valor)
                    .IsRequired();

            HasRequired(x => x.Cliente)
                .WithMany()
                .HasForeignKey(p => p.Cliente);


        }
    }
}
