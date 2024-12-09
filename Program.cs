using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_11
{
    /// <summary>
    /// Задача 10. Удаление всех четных элементов из массива.
    /// </summary>
    internal class Program
    {
        static int[] RandomArray(int length, int min, int max)
        {
            int[] array = new int[length];
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(min, max);
            }

            return array;
        }

        static void OutputArray(int[] array, string name)
        {
            Console.WriteLine($"Массив {name}:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{name}[{i}] = {array[i]}");
            }
        }

        static void Main(string[] args)
        {
            int[] omas = RandomArray(10, 0, 100);
            OutputArray(omas, "omas");

            Console.WriteLine("\nУдаление чётных элементов массива.\n");

            omas = Array.FindAll(omas, el => el % 2 != 0);
            OutputArray(omas, "omas");

            Console.ReadKey(true);
        }
    }
}
