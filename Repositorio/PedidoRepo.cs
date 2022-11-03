using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using FakeDB;

namespace Repositorio
{
    public class PedidoRepo : BaseRepo<Pedido>
    {
        public override Pedido Create(Pedido instancia)
        {
            int codigo = PedidoFakeDB.Pedidos.Last().Id + 1;
            instancia.Id = codigo;
            PedidoFakeDB.Pedidos.Add(instancia);
            return instancia;
        }

        public override Pedido ReadOne(int chave)
        {
            return PedidoFakeDB.Pedidos.SingleOrDefault(Pedido => Pedido.Id == chave);
        }

        public override List<Pedido> ReadAll()
        {
            return PedidoFakeDB.Pedidos;
        }

        public override Pedido Update(Pedido instancia)
        {
            Pedido original = this.ReadOne(instancia.Id);
            if (original == null)
            {
                return null;
            }
            else
            {
                original = instancia;
                return original;
            }
        }

        public override Pedido Delete(Pedido instancia)
        {
            Pedido original = this.ReadOne(instancia.Id);
            if (original == null)
            {
                return null;
            }
            else
            {
                PedidoFakeDB.Pedidos.Remove(original);
                return original;
            }
        }
    }
}
