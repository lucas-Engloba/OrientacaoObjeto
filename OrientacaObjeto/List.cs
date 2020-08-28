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

            Console.WriteLine();
        }

        public void ListaInserirItemNaPosicao(List<Pessoa> pessoa)
        {
            Console.WriteLine("Inserindo uma pessoa na posição 1 e outra na posição 3");
            pessoa.Insert(1, new Pessoa(78, "Bob Dylan"));
            pessoa.Insert(3, new Pessoa(81, "Jimmi Page"));

            foreach (Pessoa p in pessoa)
            {
                Console.WriteLine(p.Nome + ", " + p.Idade);
            }
            Console.WriteLine();
        }

        public void ListaRemoverItem(List<Pessoa> pessoa)
        {
            Console.WriteLine("Removendo por Objeto e Indice:  Nome=Macoratti, Nome= Jimmi Page");
            pessoa.Remove(new Pessoa(45, "Macoratti")); //Passando objeto
            pessoa.RemoveAt(3);//Remove "Jimmi Page"

            foreach (Pessoa p in pessoa)
            {
                Console.WriteLine(p.Nome + ", " + p.Idade);
            }
            Console.WriteLine();
        }

        public void ListaVerificarSeItemExiste(List<Pessoa> pessoa)
        {
            Console.Write("\nExiste na Lista Pessoa com Idade igual a 78 : {0}",
            pessoa.Exists(p => p.Idade == 78));
            Console.WriteLine("\nExiste na Lista Pessoa com Idade menor a 30 : {0}",
            pessoa.Exists(p => p.Idade < 30));

            Console.WriteLine();
        }
        public void ListaConverterParaArray(List<Pessoa> pessoa)
        {
            Console.WriteLine("Convertendo a lista para um Array");
            Pessoa[] listArray = pessoa.ToArray();

            foreach (Pessoa p in listArray)
            {
                Console.WriteLine(p.Nome + ", " + p.Idade);
            }
            Console.WriteLine();
        }

        public void ListaLocalizaPessoaMaisJovem(List<Pessoa> pessoa)
        {
            //Faz um select para trazer as pessoas com  menor idade
            List<Pessoa> Jovem = pessoa.FindAll(delegate (Pessoa p) { return p.Idade < 25; });
            Console.WriteLine("Idade é menor que 25 : ");

            Jovem.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(String.Format("{0} {1}", p.Idade, p.Nome));
            });
            Console.WriteLine();
        }
    }
}