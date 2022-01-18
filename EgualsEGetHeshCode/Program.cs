using System;
using EgualsEGetHeshCode.Model;
namespace EgualsEGetHeshCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente { Nome = "Jose", Email = "luidrocha@yahoo.com.br" };
            Cliente c2 = new Cliente { Nome = "Guilherme", Email = "Guilherme@yahoo.com.br" };


            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine("HashCode: c1:  "+ c1.GetHashCode());
            Console.Write("Comparando referencia ponteiro de memoria: " );
            Console.WriteLine(c1==c2);

            Console.WriteLine("HashCode: c2:  " + c2.GetHashCode());


            Console.ReadKey();
        }

        
    }
}
