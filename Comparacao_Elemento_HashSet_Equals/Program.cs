using System;
using Comparacao_Elemento_HashSet_Equals.Entities;
using System.Collections.Generic;

namespace Comparacao_Elemento_HashSet_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparando Classe com HashSet e Equals");
            Console.WriteLine();

            HashSet<Produto> p = new HashSet<Produto>();
            p.Add(new Produto("TV", 1500.00));
            p.Add(new Produto("NOTEBOOK", 1500.00));

            HashSet<Point> b = new HashSet<Point>();

            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));


            Produto p2 = new Produto("TV", 1500.00);

            // Comparação vai da false se IGUALS e HASCODE não tiverem implementado na clase,
            // pois faz por ferencia de memoria
            // A função Conteins utiliza esses metodos

            Console.WriteLine(p.Contains(p2));

            // Quando o tipo é Struct, compara por conteudo, mesmo não tendo implementado Iguals e HashCode
            Point point = new Point(5, 10);
            Console.WriteLine(b.Contains(point));



        }
    }
}
