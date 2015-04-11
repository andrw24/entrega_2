using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, contador=0;
            int[] vector;
            Console.WriteLine("Digite número de elementos del vector: ");
            numero = int.Parse(Console.ReadLine());
            vector = new int[numero];
            for (int cont = 0; cont < numero; cont++)
            {
                Console.WriteLine("Digite el elemento del vector: ");
                vector[cont] = int.Parse(Console.ReadLine());
            }
            foreach (int recorrido in vector)
            {
                if (recorrido > 100)
                {
                    contador++;
                }

            }
            Console.WriteLine("Los números superiores a 100 son: " + contador);
            Console.ReadKey();
        }
    }
}
