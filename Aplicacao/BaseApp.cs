using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using FakeDB;
using Repositorio;
using Servico;

namespace Aplicacao
{
    public class BaseApp
    {
        RestauranteServ rest = new RestauranteServ();

        public List<Restaurante> Mostrar()
        {
            return rest.Browse();
        }

        public void Pedir()
        {
            int codPedido;

            Console.WriteLine("Selecione o código do seu pedido: ");
            codPedido = Convert.ToInt32(Console.ReadLine());
        }
    }
}
