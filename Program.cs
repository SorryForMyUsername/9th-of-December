using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_11
{
    /// <summary>
    /// Задача 9. Поиск индекса элемента.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = { 3, 8, -24, 50, 0, 2 };
            int index = Array.IndexOf(omas, 50);
            Console.WriteLine($"Индекс элемента 50 массива omas: {index}");

            Console.ReadKey(true);
        }
    }
}
