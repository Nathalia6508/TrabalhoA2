using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using FakeDB;
using Repositorio;
using System.ComponentModel;

namespace Servico
{
    public class CardapioServ : BaseServ<Cardapio>
    {
        private CardapioRepo repositorio;

        public CardapioServ() : base ()
        {
            this.repositorio = new CardapioRepo();
        }

        public override List<Cardapio> Browse()
        {
            return this.repositorio.ReadAll();
        }

        public override Cardapio Read(int codigo)
        {
            return this.repositorio.ReadOne(codigo);
        }

        public override Cardapio Edit(Cardapio instancia)
        {
            return this.repositorio.Update(instancia);
        }

        public override Cardapio Add(Cardapio instancia)
        {
            return this.repositorio.Create(instancia);
        }

        public override Cardapio Delete(Cardapio instancia)
        {
            return this.repositorio.Delete(instancia);
        }
    }
}
