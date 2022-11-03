using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using FakeDB;

namespace Repositorio
{
    public class RestauranteRepo : BaseRepo<Restaurante>
    {
        public override Restaurante Create(Restaurante instancia)
        {
            int codigo = RestauranteFakeDB.Restaurantes.Last().Id + 1;
            instancia.Id = codigo;
            RestauranteFakeDB.Restaurantes.Add(instancia);
            return instancia;
        }

        public override Restaurante ReadOne(int chave)
        {
            return RestauranteFakeDB.Restaurantes.SingleOrDefault(Restaurante => Restaurante.Id == chave);
        }

        public override List<Restaurante> ReadAll()
        {
            return RestauranteFakeDB.Restaurantes;
        }

        public override Restaurante Update(Restaurante instancia)
        {
            Restaurante original = this.ReadOne(instancia.Id);
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

        public override Restaurante Delete(Restaurante instancia)
        {
            Restaurante original = this.ReadOne(instancia.Id);
            if (original == null)
            {
                return null;
            }
            else
            {
                RestauranteFakeDB.Restaurantes.Remove(original);
                return original;
            }
        }
    }
}
