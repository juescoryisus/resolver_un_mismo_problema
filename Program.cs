using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resolver_un_mismo_problema
{
    //---------------------------------
    //Uso de Memoria Dinámica
    //---------------------------------

    class Program
    {
        static bool NumPrim(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            int n;
            Console.Write("Ingrese la cantidad de números primos a encontrar: ");
            n = int.Parse(Console.ReadLine());

            List<int> primos = new List<int>();
            int num = 2;

            while (primos.Count < n)
            {
                if (NumPrim(num))
                {
                    primos.Add(num);
                }
                num++;
            }

            Console.WriteLine($"Los primeros {n} números primos son:");
            foreach (int primo in primos)
            {
                Console.Write(primo + " ");
            }

        }
    }
    //------------------------------------------------
    //Generación de Vectores en Tiempo de Ejecución
    //------------------------------------------------

    //class Program
    //{
    //    static bool EsPrimo(int num)
    //    {
    //        if (num <= 1)
    //            return false;

    //        for (int i = 2; i * i <= num; i++)
    //        {
    //            if (num % i == 0)
    //                return false;
    //        }

    //        return true;
    //    }

    //    static void Main(string[] args)
    //    {
    //        int n;
    //        Console.Write("Ingrese la cantidad de números primos a encontrar: ");
    //        n = int.Parse(Console.ReadLine());

    //        int[] primos = new int[n];
    //        int contador = 0;
    //        int num = 2;

    //        while (contador < n)
    //        {
    //            if (EsPrimo(num))
    //            {
    //                primos[contador] = num;
    //                contador++;
    //            }
    //            num++;
    //        }

    //        Console.WriteLine($"Los primeros {n} números primos son:");
    //        foreach (int primo in primos)
    //        {
    //            Console.Write(primo + " ");
    //        }
    //    }
    //}
}


