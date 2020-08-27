using OrientacaObjeto.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaObjeto
{
    class List
    {
        public void ForechPessoa(List<Pessoa> pessoa)
        {
            Console.WriteLine("Metodo ForeachPessoa");
            Console.WriteLine();
            foreach (Pessoa p in pessoa)
            {
                Console.WriteLine(p.Nome + ", " + p.Idade);
            }
            Console.WriteLine();
        }

        public void ListaNaoOrdenada(List<Pessoa> pessoa)
        {
            Console.WriteLine("Metodo ForEaChPessoa, Lista não ordenada");
            Console.WriteLine();

            pessoa.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(string.Format("{0},{1}", p.Nome, p.Idade));
            });

            Console.WriteLine();
        }

        public void ListaOrdenada(List<Pessoa> pessoa)
        {
            Console.WriteLine("metodo Sort, Lista Ordenada por Nome");
            Console.WriteLine();

            pessoa.Sort(delegate (Pessoa p, Pessoa p1)
            {
                return p.Idade.CompareTo(p1.Idade);
            });

            pessoa.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine("{0} {1}", p.Idade, p.Nome);
            });
        }
    }
}
