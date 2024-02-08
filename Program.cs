using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notascon_porcentaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, notafinal;
          


            Console.WriteLine(" Ingrese nota 1 ");
            nota1 = float.Parse(Console.ReadLine());
            nota1 = (float)(nota1 * 0.3);

            Console.WriteLine("nota 1 es igual a: " + nota1  + "\n");
 
            Console.WriteLine(" Ingrese nota 2 ");
            nota2 = float.Parse(Console.ReadLine());
            nota2 = (float)(nota2 * 0.3);

            Console.WriteLine("nota 2 es igual a: " + nota2 + "\n");

            Console.WriteLine(" Ingrese nota 3 ");
            nota3 = float.Parse(Console.ReadLine());
            nota3 = (float)(nota3 * 0.4);

            Console.WriteLine("nota 3 es igual a: " + nota3 + "\n");

            notafinal = nota1 + nota2 + nota3 ;

            Console.WriteLine(" Su nota final es: " + notafinal);

            Console.ReadKey();

        }

    }
}
