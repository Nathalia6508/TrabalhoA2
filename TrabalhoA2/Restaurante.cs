using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Restaurante
    {
        string endereco;
        string nome;
        string descricao;
        int id;

        public string Endereco { get => endereco; set => endereco = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Id { get => id; set => id = value; }

        public Restaurante(string endereco, string nome, string descricao, int id)
        {
            this.Endereco = endereco;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Id = id;
        }

        public Restaurante()
        { }

        Cardapio cardapio = new Cardapio();
    }
}
