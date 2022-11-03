using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace FakeDB
{
    public static class PedidoFakeDB
    {
        private static List<Pedido> pedidos;

        public static List<Pedido> Pedidos
        {
            get
            {
                if (Pedidos == null)
                {
                    pedidos = new List<Pedido>();
                    Preencher();
                }
                return pedidos;
            }
        }

        private static void Preencher()
        {
            pedidos.Add(new Pedido(1));
            pedidos.Add(new Pedido(2));
            pedidos.Add(new Pedido(3));
            pedidos.Add(new Pedido(4));
            pedidos.Add(new Pedido(5));
            pedidos.Add(new Pedido(6));
            pedidos.Add(new Pedido(7));
            pedidos.Add(new Pedido(8));
            pedidos.Add(new Pedido(9));
            pedidos.Add(new Pedido(10));
        }
    }
}
