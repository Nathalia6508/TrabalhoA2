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
    public class FisicaServ : BaseServ<Fisica>
    {
        private FisicaRepo repositorio;

        public FisicaServ() : base()
        {
            this.repositorio = new FisicaRepo();
        }

        public override List<Fisica> Browse()
        {
            return this.repositorio.ReadAll();
        }

        public override Fisica Read(int codigo)
        {
            return this.repositorio.ReadOne(codigo);
        }

        public override Fisica Edit(Fisica instancia)
        {
            return this.repositorio.Update(instancia);
        }

        public override Fisica Add(Fisica instancia)
        {
            return this.repositorio.Create(instancia);
        }

        public override Fisica Delete(Fisica instancia)
        {
            return this.repositorio.Delete(instancia);
        }
    }
}
