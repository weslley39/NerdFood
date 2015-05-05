using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NerdFood.Domain.Entities;

namespace NerdFood.Infrastructure.Data.Config
{
    public class EmpresaConfiguration : EntityTypeConfiguration<Empresa>
    {
        public EmpresaConfiguration()
        {
            HasKey(x => x.EmpresaId);

            Property(x => x.NomeFantasia)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
