using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pedido
    {
        private int id;
        public int Id { get => id; set => id = value; }

        public Pedido()
        { }

        public Pedido(int id)
        {
            this.Id = id;
        }
    }
}
