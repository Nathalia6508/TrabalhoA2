using Dominio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using FakeDB;
using Repositorio;

namespace Servico
{
    public class PedidoServ : BaseServ<Pedido>
    {
        private PedidoRepo repositorio;

        public PedidoServ() : base()
        {
            this.repositorio = new PedidoRepo();
        }

        public override List<Pedido> Browse()
        {
            return this.repositorio.ReadAll();
        }

        public override Pedido Read(int codigo)
        {
            return this.repositorio.ReadOne(codigo);
        }

        public override Pedido Edit(Pedido instancia)
        {
            return this.repositorio.Update(instancia);
        }

        public override Pedido Add(Pedido instancia)
        {
            return this.repositorio.Create(instancia);
        }

        public override Pedido Delete(Pedido instancia)
        {
            return this.repositorio.Delete(instancia);
        }
    }
}
