using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using FakeDB;

namespace Repositorio
{
    public class JuridicaRepo : BaseRepo<Juridica>
    {
        public override Juridica Create(Juridica instancia)
        {
            int codigo = JuridicaFakeDB.PessoasJuridicas.Last().Id + 1;
            instancia.Id = codigo;
            JuridicaFakeDB.PessoasJuridicas.Add(instancia);
            return instancia;
        }

        public override Juridica ReadOne(int chave)
        {
            return JuridicaFakeDB.PessoasJuridicas.SingleOrDefault(Juridica => Juridica.Id == chave);
        }

        public override List<Juridica> ReadAll()
        {
            return JuridicaFakeDB.PessoasJuridicas;
        }

        public override Juridica Update(Juridica instancia)
        {
            Juridica original = this.ReadOne(instancia.Id);
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

        public override Juridica Delete(Juridica instancia)
        {
            Juridica original = this.ReadOne(instancia.Id);
            if (original == null)
            {
                return null;
            }
            else
            {
                JuridicaFakeDB.PessoasJuridicas.Remove(original);
                return original;
            }
        }
    }
}
