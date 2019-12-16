using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {

        public ClienteConfiguration()
        {

            HasKey(x => x.ClienteId);

            Property(x => x.Nome)
                    .IsRequired()
                    .HasMaxLength(150);

            Property(x => x.SobreNome)
                        .IsRequired()
                        .HasMaxLength(150);

            Property(c => c.Email)
             .IsRequired();


        }



    }
}
