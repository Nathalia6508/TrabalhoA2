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
    public class RestauranteServ : BaseServ<Restaurante>
    {
        private RestauranteRepo repositorio;

        public RestauranteServ() : base()
        {
            this.repositorio = new RestauranteRepo();
        }

        public override List<Restaurante> Browse()
        {
            return this.repositorio.ReadAll();
        }

        public override Restaurante Read(int codigo)
        {
            return this.repositorio.ReadOne(codigo);
        }

        public override Restaurante Edit(Restaurante instancia)
        {
            return this.repositorio.Update(instancia);
        }

        public override Restaurante Add(Restaurante instancia)
        {
            return this.repositorio.Create(instancia);
        }

        public override Restaurante Delete(Restaurante instancia)
        {
            return this.repositorio.Delete(instancia);
        }
    }
}
