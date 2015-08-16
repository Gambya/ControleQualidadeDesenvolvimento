using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortalQualidade.Domain.ValueObjects;

namespace PortalQualidade.Domain.Entities
{
    public class Usuario:EntityBase
    {
        public string Nome { get; private set; }
        public Email _Email { get; private set; }
        public string Departamento { get; private set; }
        public bool Nivel { get; private set; }
        public bool Flag { get; private set; }

        protected Usuario(){}

        public Usuario(string nome, Email email, string departamento)
        {
            this.Nome = nome;
            this._Email = email;
            this.Departamento = departamento;
        }
    }
}
