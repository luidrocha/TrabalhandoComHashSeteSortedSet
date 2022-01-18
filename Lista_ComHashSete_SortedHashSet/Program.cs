using System;
using System.Collections.Generic;


namespace Lista_ComHashSete_SortedHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> listaSet = new HashSet<string>();

            listaSet.Add("TV");
            listaSet.Add("SOM");
            listaSet.Add("BRINQUEDO");
            listaSet.Add("CELULAR");
            listaSet.Add("TABLET");
            listaSet.Add("NOTEBOOK");

            Console.WriteLine("Conteim? " + listaSet.Contains("celular"));

            Console.WriteLine();

            foreach (string p in listaSet)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("===============================");
            Console.WriteLine("Trabalhando com SORTEDSET");
            Console.WriteLine("===============================");

            SortedSet<int> g1 = new SortedSet<int> { 0, 2, 4, 6, 8, 10 };
            SortedSet<int> g2 = new SortedSet<int> { 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Imprimindo Coleções");
            printCollections(g1);
            Console.WriteLine();
            printCollections(g2);
            
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Unindo Coleções");
            Console.WriteLine();

            // UNION

            SortedSet<int> g3 = new SortedSet<int>(g1); // Cria um nova lista com os valores de g1 
            g3.UnionWith(g2); // Cria a nova lista com os valores ordenados

            Console.WriteLine("União g1 e g2");
            printCollections(g3);


            // INTERSECTION 
            Console.WriteLine("Interseção g1 e g2"); // Elementos que existem nos 2 conjuntos


            SortedSet<int> g4 = new SortedSet<int>(g1); // Cria um nova lista com os valores de g1 
            g3.IntersectWith(g2); // Cria a nova lista com os valores ordenados

            Console.WriteLine("intercessão g1 e g2");
            printCollections(g4);


            // DIFRENÇA
            // Elementos de A excluindo elementos de B

            Console.WriteLine("Diferença g1 e g2"); // Elementos que existem nos 2 conjuntos


            SortedSet<int> g5 = new SortedSet<int>(g1); // Cria um nova lista com os valores de g1 
            g5.ExceptWith(g2); // Cria a nova lista com os valores ordenados

            Console.WriteLine("Diferença g1 e g2");
            printCollections(g5);




            Console.ReadKey();
        }

        static void printCollections<T>(IEnumerable<T> collections) // Ienumerable para percorrer a coleção
        {
            foreach (T obj in collections)
            {
                Console.Write(obj + ", ");
            }


        }

    }
}
