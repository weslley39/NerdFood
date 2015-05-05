using NerdFood.Domain.Entities;
using NerdFood.Domain.Interfaces.Repository;
using NerdFood.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdFood.Domain.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _repository;

        public EmpresaService(IEmpresaRepository empresaRepository)
        {
            _repository = empresaRepository;
        }

        public List<Empresa> RetornarListaPorColecaoId(int[] ids)
        {
            List<Empresa> listaEmpresa = new List<Empresa>();

            foreach (int EmpId in ids)
            {
                var empresa = _repository.GetById(EmpId);
                if (empresa != null)
                {
                    listaEmpresa.Add(empresa);
                }
            }

            return listaEmpresa;
        }

        public void Incluir(Empresa empresa)
        {
            _repository.Add(empresa);
        }

        public IEnumerable<Empresa> ObterTodos()
        {
            return _repository.All();
        }

        public Empresa ObterPorID(int id)
        {
            return _repository.GetById(id);
        }

        public void Editar(Empresa empresa)
        {
            _repository.Update(empresa);
        }

        public void Excluir(Empresa empresa)
        {
            _repository.Delete(empresa);
        }
    }
}
