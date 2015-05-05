using System;
using System.Collections.Generic;

namespace NerdFood.Domain.Entities
{
    public class Empresa
    {
        public int EmpresaId { get; set; }

        public DateTime DataAbertura { get; set; }

        public string NomeFantasia { get; set; }

        public virtual List<Cliente> ClienteList { get; set; }
    }
}
