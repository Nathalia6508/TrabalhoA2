using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace FakeDB
{
    public class FisicaFakeDB
    {
        private static List<Fisica> pessoasFisicas;

        public static List<Fisica> PessoasFisicas
        {
            get
            {
                if (PessoasFisicas == null)
                {
                    pessoasFisicas = new List<Fisica>();
                    Preencher();
                }
                return pessoasFisicas;
            }
        }

        public static void Preencher()
        {
            pessoasFisicas.Add(new Fisica(new DateTime(1975, 03, 15), "Maria", "maria123@gmail.com", "67998889988", "São Paulo", "123", 1, "99999999999"));
            pessoasFisicas.Add(new Fisica(new DateTime(1982, 12, 18), "Marta", "marta@gmail.com", "67998889988", "São Paulo", "1234", 2, "99999998889"));
            pessoasFisicas.Add(new Fisica(new DateTime(1982, 12, 18), "Marta", "marta@gmail.com", "67998889988", "São Paulo", "1234", 3, "99999998889"));
            pessoasFisicas.Add(new Fisica(new DateTime(2000, 03, 17), "João", "joaof@gmail.com", "67997777988", "Dourados", "batatinha", 3, "77777777777"));
            pessoasFisicas.Add(new Fisica(new DateTime(1999, 08, 17), "Marcos", "marcosaugusto@gmail.com", "67997774444", "Campo Grande", "abcdefg", 4, "77775557777"));
            pessoasFisicas.Add(new Fisica(new DateTime(2000, 03, 19), "João", "joaod@gmail.com", "67997777988", "Maceió", "123456", 5, "77777788977"));
            pessoasFisicas.Add(new Fisica(new DateTime(1997, 03, 19), "Larissa", "larissamatos@gmail.com", "6788777988", "Campo Grande", "19031997", 6,"74444488977"));
            pessoasFisicas.Add(new Fisica(new DateTime(1995, 06, 20), "Madalena", "joaof@gmail.com", "67997777988", "Goiania", "batatinha", 7, "77777788977"));
            pessoasFisicas.Add(new Fisica(new DateTime(2000, 03, 19), "Vitor", "vitorm@gmail.com", "67997799998", "Aquidauana", "enzo", 8, "76667788977"));
            pessoasFisicas.Add(new Fisica(new DateTime(2002, 11, 20), "Leticia", "leticiap@gmail.com", "67997799998", "Dourados", "laura", 9, "76667555577"));
            pessoasFisicas.Add(new Fisica(new DateTime(2003, 01, 15), "Nayara", "nayaraam@gmail.com", "67997779998", "Campo Grande", "15012003", 10, "76664444477"));
        }
    }
}
