using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparacao_Elemento_HashSet_Equals.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode()+Preco.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Produto))
            {
                return false;
            }

            Produto other = obj as Produto;

            return Nome.Equals(other.Nome) && Preco.Equals(other.Preco);
        }
    }
}
