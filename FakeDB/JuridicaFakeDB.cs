using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDB
{
    public class JuridicaFakeDB
    {
        private static List<Juridica> pessoasJuridicas;

        public static List<Juridica> PessoasJuridicas
        {
            get
            {
                if (PessoasJuridicas == null)
                {
                    pessoasJuridicas = new List<Juridica>();
                    Preencher();
                }
                return pessoasJuridicas;
            }
        }

        public static void Preencher()
        {
            pessoasJuridicas.Add(new Juridica(new DateTime(1975, 03, 15), "João da Silva", "joaos@gmail.com", "67998889988", "São Paulo", "123", 1, "99999999000199"));
            pessoasJuridicas.Add(new Juridica(new DateTime(1990, 08, 15), "TED Lanches", "lan.x.net@gmail.com", "67998889988", "Campo Grande", "1234", 2, "88899999000199"));
            pessoasJuridicas.Add(new Juridica(new DateTime(2000, 03, 18), "Ana Fatima", "anafat@gmail.com", "67996666988", "São Paulo", "6699778", 3, "99999910000179"));
            pessoasJuridicas.Add(new Juridica(new DateTime(1975, 03, 15), "João da Silva", "joaos@gmail.com", "67998889988", "São Paulo", "456", 4, "99999999000199"));
            pessoasJuridicas.Add(new Juridica(new DateTime(1975, 03, 15), "Alberto R Santos", "albsantos@gmail.com", "67997777988", "Cuiabá", "1445", 5, "97777799000159"));
            pessoasJuridicas.Add(new Juridica(new DateTime(1975, 03, 15), "João Roberto", "joaor@gmail.com", "67999999988", "Campo Grande", "123", 6, "99955559000199"));
            pessoasJuridicas.Add(new Juridica(new DateTime(1975, 03, 15), "Vitor Braga", "vitor.braga@gmail.com", "67998888888", "São Paulo", "5889", 7, "8888888000199"));
            pessoasJuridicas.Add(new Juridica(new DateTime(1975, 03, 15), "Larissa Monteiro", "larissam@gmail.com", "67998889988", "São Paulo", "123", 8, "99999999000299"));
            pessoasJuridicas.Add(new Juridica(new DateTime(1975, 03, 15), "Maria Abreu", "mariaab@gmail.com", "67998333988", "Dourados", "258", 9, "99995559000199"));
            pessoasJuridicas.Add(new Juridica(new DateTime(1975, 03, 15), "João da Silva", "joaos@gmail.com", "67998877988", "São Paulo", "123", 10, "99999559000199"));
        }
       
    }
}
