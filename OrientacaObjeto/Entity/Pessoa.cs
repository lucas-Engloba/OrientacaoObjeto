using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaObjeto.Entity
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(int idade, string nome)
        {
            Idade = idade;
            Nome = nome;
        }
    }
}
