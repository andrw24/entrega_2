﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=0, suma=0;
            do
            {
                Console.WriteLine("Digite número: ");
                numero = int.Parse(Console.ReadLine());
                if (numero == 9999)
                    break;

                suma += numero;
             }


            while (numero != 9999);
            Console.WriteLine("La suma es: "+suma);
            if (suma == 0)
            {
                Console.WriteLine("La suma es igual a cero");
            }
            else if (suma > 0)
            {
                Console.WriteLine("La suma es mayor a cero");
            }
            else
            {
                Console.WriteLine("La suma es menor a cero");
            }
        Console.ReadKey();

        }
    }
}
