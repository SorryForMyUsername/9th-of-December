using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_11
{
    /// <summary>
    /// Задача 10. Удаление всех четных элементов из массива и в новом массиве сложить элементы.
    /// </summary>
    internal class Program
    {
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
            int[] omas = { 3, 7, 1, 9, 5, 6, 8, 10 };
            omas = omas.Where(x => x % 2 != 0).ToArray();
            OutputArray(omas, "omas");

            int sum = omas.Sum();
            Console.WriteLine($"Сумма элементов нового массива: {sum}");

            Console.ReadKey(true);
        }
    }
}
