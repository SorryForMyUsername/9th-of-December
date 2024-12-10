using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_11
{
    /// <summary>
    /// Задача 13. Заполните одномерный массив числовыми данными случайным образом из промежутка [ - 50;50]. 
    /// Подсчитайте количество элементов массива, кратных 3 (размерность массива равна 15).
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
            int[] omas = RandomArray(15, -50, 50);
            int multipliesOfTreeCount = omas.Count(x => x % 3 == 0);
            Console.WriteLine($"Кол-во элементов кратных трём: {multipliesOfTreeCount}");

            Console.ReadKey();
        }
    }
}
