using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDoWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, suma=0, cantidad = 0, promedio;
            do
            {
               Console.WriteLine("Digite números: ");
                num = int.Parse(Console.ReadLine());

                if (num != 0)
                {
                    suma = suma + num;
                    cantidad++;
                }
            }
            while (num != 0);
            {
                if (cantidad != 0)
                {
                    promedio = suma / cantidad;
                    Console.WriteLine("El promedio de los valores es: " + promedio);
                }

            }

            Console.ReadKey();


        }
    }
}
