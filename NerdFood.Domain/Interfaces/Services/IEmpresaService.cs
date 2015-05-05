using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NerdFood.Domain.Entities;

namespace NerdFood.Domain.Interfaces.Services
{
    public interface IEmpresaService
    {
        List<Empresa> RetornarListaPorColecaoId(int[] ids);

        void Incluir(Empresa empresa);

        IEnumerable<Empresa> ObterTodos();

        Empresa ObterPorID(int id);

        void Editar(Empresa empresa);

        void Excluir(Empresa empresa);
    }
}
