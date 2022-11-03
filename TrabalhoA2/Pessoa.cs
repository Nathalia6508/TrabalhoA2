using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Pessoa
    {
        public DateTime dataNasc = new DateTime();
        public string nome;
        public string email;
        public string telefone;
        public string cidade;
        public string password;
        public int id;

        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }

        public Pessoa()
        { }

        public Pessoa(DateTime dataNasc, string nome, string email, string telefone, string cidade, string password, int id)
        {
            this.DataNasc = dataNasc;
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.Cidade = cidade;
            this.Password = password;
            this.Id = id;
            
        }

        Pedido pedido = new Pedido();
        Restaurante restaurante = new Restaurante();
    }
}
