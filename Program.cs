using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_11
{
    /// <summary>
    /// Задача 7. Поиск элемента по условию.
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

        static void Find(int[] array, Func<int, bool> condition)
        {
            try
            {
                int element = array.First(condition);
                Console.WriteLine($"Элемент, соответствующий условию: {element}.");
            }
            catch
            {
                Console.WriteLine($"В массиве нет элементов, удовлетворяющих условию.");
            }
        }

        static void Main(string[] args)
        {
            int[] omas = RandomArray(100, 0, 100);
            Find(omas, x => x >= 50 && x <= 60);

            Console.ReadKey(true);
        }
    }
}
