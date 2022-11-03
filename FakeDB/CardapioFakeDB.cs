using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace FakeDB
{
    public class CardapioFakeDB
    {
        private static List<Cardapio> cardapios;

        public static List<Cardapio> Cardapios
        {
            get
            {
                if (Cardapios == null)
                {
                    cardapios = new List<Cardapio>();
                    Preencher();
                }
                return cardapios;
            }
        }

        public static void Preencher()
        {
            cardapios.Add(new Cardapio("Espetinho de carne", "Espeto com carne", 10.40, "jpg", 1));
            cardapios.Add(new Cardapio("Marmitex", "Marmita com bife e batata", 15.90, "jpg", 2));
            cardapios.Add(new Cardapio("Pizza de calabresa", "Pizza com recheio de calabresa", 30.98, "jpg", 3));
            cardapios.Add(new Cardapio("Espetinho de camarão", "Espetinho com camarão", 37.50, "jpg", 4));
            cardapios.Add(new Cardapio("x-salada", "Hamburguer com salada", 37.90, "jpg", 5));
            cardapios.Add(new Cardapio("Purê de Batata", "Batata amassada com leite", 27.80, "jpg", 6));
            cardapios.Add(new Cardapio("Marmitex de frango", "Marmita com frango assado", 15.90, "jpg", 7));
            cardapios.Add(new Cardapio("Pizza de 4 queijos", "Pizza com recheio de 4 queijos", 46.80, "jpg", 8));
            cardapios.Add(new Cardapio("Dobradinha", "Estômago de boi", 38.15, "jpg", 9));
            cardapios.Add(new Cardapio("x-frango", "Hamburguer com frango", 10.40, "jpg", 10));
        }
    }
}
