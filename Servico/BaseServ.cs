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
    public abstract class BaseServ<TDominio> where TDominio : class
    {
        public abstract List<TDominio> Browse();

        public abstract TDominio Read(int codigo);

        public abstract TDominio Edit(TDominio instancia);

        public abstract TDominio Add(TDominio instancia);

        public abstract TDominio Delete(TDominio instancia);
    }
}
