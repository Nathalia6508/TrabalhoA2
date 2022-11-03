using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using FakeDB;

namespace Repositorio
{
    public class CardapioRepo : BaseRepo<Cardapio>
    {
        public override Cardapio Create(Cardapio instancia)
        {
            int codigo = CardapioFakeDB.Cardapios.Last().Id + 1;
            instancia.Id = codigo;
            CardapioFakeDB.Cardapios.Add(instancia);
            return instancia;
        }

        public override Cardapio ReadOne(int chave)
        {
            return CardapioFakeDB.Cardapios.SingleOrDefault(cardapio => cardapio.Id == chave);
        }

        public override List<Cardapio> ReadAll()
        {
            return CardapioFakeDB.Cardapios;
        }

        public override Cardapio Update(Cardapio instancia)
        {
            Cardapio original = this.ReadOne(instancia.Id);
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

        public override Cardapio Delete(Cardapio instancia)
        {
            Cardapio original = this.ReadOne(instancia.Id);
            if (original == null)
            {
                return null;
            }
            else
            {
                CardapioFakeDB.Cardapios.Remove(original);
                return original;
            }
        }
    }
}
