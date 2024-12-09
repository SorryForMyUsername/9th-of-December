using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_11
{
    /// <summary>
    /// Задача 1. Определить количество элементов одномерного массива.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = { 1, 2, 3, 0, 4, -2 };
            Console.WriteLine($"Размер: {omas.Length}");

            string[] array = { "Hello", "world", "!" };
            int length = array.Length;
            Console.WriteLine($"Размер: {length}");
        }
    }
}
