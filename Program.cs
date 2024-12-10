using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_11
{
    /// <summary>
    /// Задача 14. Дан курс рубля России за январь 2023 года. Рассчитать:
    /// а) среднее значение КВ (СКВ);
    /// б) максимальное значение КВ  (МаксКВ);
    /// в) минимальное значение КВ  (МинКВ);
    /// г) день с максимальным значением КВ  (МаксКВД);
    /// д) день с минимальным значением КВ  (МинКВД).
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
            string[] people = { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };
            string first = Array.Find(people, person => person.Length > 3);
            string end = Array.FindLast(people, person => person.Length > 3);
            Console.WriteLine(first);
            Console.WriteLine(end);

            string[] nameLengthIs3 = Array.FindAll(people, person => person.Length == 3);
            OutputArray(nameLengthIs3, "nameLengthIs3");

            Console.ReadKey(true);
        }
    }
}
