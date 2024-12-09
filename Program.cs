using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_11
{
    /// <summary>
    /// Задача 2. Обнулить заданный диапазон элементов в одномерном массиве.
    /// </summary>
    internal class Program
    {
        static int Size()
        {
            Console.Write("Размер о.м.: ");
            int size;
            while(!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Ошибка");
            }
            return size;
        }

        static int[] Input(int length, string name)
        {
            int[] array = new int[length];

            for(int i = 0; i < length; i++)
            {
                Console.Write($"{name}[{i}] = ");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        static void OutputArray(int[] array, string name)
        {
            Console.WriteLine($"Массив {name}:");

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{name}[{i}] = {array[i]}");
            }
        }

        static void Main(string[] args)
        {
            int[] omas = Input(Size(), "omas");
            Array.Clear(omas, 1, 2);
            OutputArray(omas, "omas");
        }
    }
}
