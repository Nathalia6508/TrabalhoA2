using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Fisica : Pessoa
    {
        private string cpf;
        public string Cpf { get => cpf; set => cpf = value; }

        public Fisica() : base()
        { }
        public Fisica(DateTime dataNasc, string nome, string email, string telefone, string cidade, string password, int id, string cpf) 
        : base (dataNasc, nome, email, telefone, cidade, password, id)
        {
            DataNasc = dataNasc;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Cidade = cidade;
            Password = password;
            Id = id;
            this.Cpf = cpf;
        }

        private static int CalcularIdade(DateTime dataNasc)
        {
            int idade = DateTime.Now.Year - dataNasc.Year;
            if (DateTime.Now.DayOfYear < dataNasc.DayOfYear)
            {
                idade = idade - 1;
            }

            return idade;
        }
    }
}
