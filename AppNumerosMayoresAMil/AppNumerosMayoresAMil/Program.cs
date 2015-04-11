using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNumerosMayoresAMil
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad, n, i,num;
            cantidad = 0;
            Console.WriteLine("Digite cantidad de numeros: ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Ingrese N° " + i);
                num = int.Parse(Console.ReadLine());
                if (num > 1000)
                {
                    cantidad = cantidad + 1;
                }

            }
            Console.WriteLine("La cantidad de numeros mayores a 1000 es: " + cantidad);
            Console.ReadKey();


        }
    }
}
