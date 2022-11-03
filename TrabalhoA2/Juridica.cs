using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Juridica : Pessoa
    {
        string cnpj;

        public string Cnpj { get => cnpj; set => cnpj = value; }

        public Juridica() : base ()
        { }
        public Juridica(DateTime dataNasc, string nome, string email, string telefone, string cidade, string password, int id, string cnpj)
        : base(dataNasc, nome, email, telefone, cidade, password, id)
        {
            DataNasc = dataNasc;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Cidade = cidade;
            Password = password;
            Id = id;
            this.Cnpj = cnpj;
        }
    }
}
