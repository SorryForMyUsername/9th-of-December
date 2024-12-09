using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_11
{
    /// <summary>
    /// Задача 6. Подсчет количества вхождений определенного числа в массив.
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

        static void Main(string[] args)
        {
            int[] omas = RandomArray(100, 0, 10);
            int countFive = omas.Count(x => x == 5);
            Console.WriteLine($"Кол-во вхождений числа 5 в массив: {countFive}");

            Console.ReadKey(true);
        }
    }
}
