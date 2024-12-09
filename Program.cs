using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_11
{
    /// <summary>
    /// Задача 3. Найти максимальное и минимальное значение в массиве.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = { 3, 8, -24, 50, 0, 2 };
            int max = omas.Max();
            int min = omas.Min();
            Console.WriteLine($"Max: {max}\nMin: {min}");
        }
    }
}
