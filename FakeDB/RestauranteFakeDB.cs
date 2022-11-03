using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDB
{
    public class RestauranteFakeDB
    {
        private static List<Restaurante> restaurantes;

        public static List<Restaurante> Restaurantes
        {
            get
            {
                if (restaurantes == null)
                {
                    restaurantes = new List<Restaurante>();
                    Preencher();
                }
                return restaurantes;
            }
        }

        private static void Preencher()
        {
            restaurantes.Add(new Restaurante("Rua das Oliveiras, 207", "Dona Maria", "Churrascaria", 1));
            restaurantes.Add(new Restaurante("Rua das Palmeiras, 399", "Restaurante da vó", "Marmitaria", 2));
            restaurantes.Add(new Restaurante("Rua das Flores, 27", "Don Didio", "Pizzaria", 3));
            restaurantes.Add(new Restaurante("Rua dos Coqueiros, 68", "Casa de Mainha", "Restaurante nordestino", 4));
            restaurantes.Add(new Restaurante("Rua Armando Costa, 358", "TED Lanches", "Lanchonete", 5));
            restaurantes.Add(new Restaurante("Rua dos Bobos, 0", "Dona Sofia", "Prato feito", 6));
            restaurantes.Add(new Restaurante("Rua das Palmeiras, 399", "Restaurante da vó", "Marmitaria", 7));
            restaurantes.Add(new Restaurante("Rua das Flores, 27", "Don Didio", "Pizzaria", 8));
            restaurantes.Add(new Restaurante("Rua dos Coqueiros, 68", "Casa de Mainha", "Restaurante nordestino", 9));
            restaurantes.Add(new Restaurante("Rua Armando Costa, 358", "TED Lanches", "Lanchonete", 10));
        }
    }
}
