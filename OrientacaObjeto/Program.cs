using OrientacaObjeto.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaObjeto
{
    class Program
    {
        static List<Pessoa> pessoas;
        static void Main(string[] args)
        {
            pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa(50, "Macoratti"));
            pessoas.Add(new Pessoa(25, "Jefferson"));
            pessoas.Add(new Pessoa(45, "Miriam"));
            pessoas.Add(new Pessoa(46, null));

            List list = new List();
            list.ForechPessoa(pessoas);
            list.ListaNaoOrdenada(pessoas);
            list.ListaOrdenada(pessoas);
            list.ListaInserirItemNaPosicao(pessoas);
            list.ListaRemoverItem(pessoas);
            list.ListaVerificarSeItemExiste(pessoas);
            list.ListaConverterParaArray(pessoas);
            list.ListaLocalizaPessoaMaisJovem(pessoas);

        }
    }
}
