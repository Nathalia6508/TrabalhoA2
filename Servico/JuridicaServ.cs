using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using FakeDB;
using Repositorio;

namespace Servico
{
    public class JuridicaServ : BaseServ<Juridica>
    {
        private JuridicaRepo repositorio;

        public JuridicaServ() : base()
        {
            this.repositorio = new JuridicaRepo();
        }

        public override List<Juridica> Browse()
        {
            return this.repositorio.ReadAll();
        }

        public override Juridica Read(int codigo)
        {
            return this.repositorio.ReadOne(codigo);
        }

        public override Juridica Edit(Juridica instancia)
        {
            return this.repositorio.Update(instancia);
        }

        public override Juridica Add(Juridica instancia)
        {
            return this.repositorio.Create(instancia);
        }

        public override Juridica Delete(Juridica instancia)
        {
            return this.repositorio.Delete(instancia);
        }
    }
}
