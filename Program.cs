using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_11
{
    /// <summary>
    /// Задача 8. Изменение размера массива.
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

            Console.WriteLine("\nУменьшение размера массива на 2\n");

            Array.Resize(ref fruits, 2);
            OutputArray(fruits, "fruits");

            Console.ReadKey(true);
        }
    }
}
