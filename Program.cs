using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_11
{
    /// <summary>
    /// Задача 5. Реверс массива.
    /// </summary>
    internal class Program
    {
        static void OutputArray(string[] array, string name)
        {
            Console.WriteLine($"Массив {name}:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{name}[{i}] = {array[i]}");
            }
        }

        static void Main(string[] args)
        {
            string[] fruits = { "яблоко", "груша", "апельсин", "мандарин" };
            OutputArray(fruits, "fruits");

            Array.Reverse(fruits);
            OutputArray(fruits, "fruits");

            Console.ReadKey(true);
        }
    }
}
