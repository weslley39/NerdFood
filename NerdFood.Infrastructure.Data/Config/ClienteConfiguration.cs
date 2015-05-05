using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NerdFood.Domain.Entities;

namespace NerdFood.Infrastructure.Data.Config
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(x => x.ClienteId);

            Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
