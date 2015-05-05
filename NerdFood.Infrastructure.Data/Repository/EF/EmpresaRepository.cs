using NerdFood.Domain;
using NerdFood.Domain.Entities;
using NerdFood.Domain.Interfaces.Repository;
using NerdFood.Infra.Data.Repository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdFood.Infrastructure.Data.Repository.EF
{
    public class EmpresaRepository : BaseRepository<Empresa>, IEmpresaRepository
    {
    }
}
