using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using FakeDB;

namespace Repositorio
{
    public class FisicaRepo : BaseRepo<Fisica>
    {
        public override Fisica Create(Fisica instancia)
        {
            int codigo = FisicaFakeDB.PessoasFisicas.Last().Id + 1;
            instancia.Id = codigo;
            FisicaFakeDB.PessoasFisicas.Add(instancia);
            return instancia;
        }

        public override Fisica ReadOne(int chave)
        {
            return FisicaFakeDB.PessoasFisicas.SingleOrDefault(fisica => fisica.Id == chave);
        }

        public override List<Fisica> ReadAll()
        {
            return FisicaFakeDB.PessoasFisicas;
        }

        public override Fisica Update(Fisica instancia)
        {
            Fisica original = this.ReadOne(instancia.Id);
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

        public override Fisica Delete(Fisica instancia)
        {
            Fisica original = this.ReadOne(instancia.Id);
            if (original == null)
            {
                return null;
            }
            else
            {
                FisicaFakeDB.PessoasFisicas.Remove(original);
                return original;
            }
        }
    }
}
