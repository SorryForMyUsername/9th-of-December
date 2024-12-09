using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_11
{
    /// <summary>
    /// Задача 12. Умножение всех элементов массива на определенное число.
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

        static void MultiplyArray(ref int[] array)
        {
            Console.Write("На сколько умножить элементы массива? ");
            int multiplier = int.Parse(Console.ReadLine());

            array = array.Select(el => el * multiplier).ToArray();
        }

        static void Main(string[] args)
        {
            int[] omas = RandomArray(5, 0, 10);
            OutputArray(omas, "omas");

            MultiplyArray(ref omas);
            OutputArray(omas, "omas");

            Console.ReadKey(true);
        }
    }
}
