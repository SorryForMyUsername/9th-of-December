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

        static void Output(string output)
        {
            Console.WriteLine(output);
        }

        static void Main(string[] args)
        {
            double[] dollarExchangeRate = { 70.3375, 70.3375, 70.3375, 70.3375, 70.3375, 70.3375, 70.3375, 70.3375, 70.3375, 70.3002, 69.6094, 69.0202, 67.7775, 67.5744, 67.5744, 67.5744, 68.2892, 68.6644, 68.8728, 68.8467, 68.6656, 68.6656, 68.6656, 68.6288, 68.7529, 68.9573, 69.1263, 69.3372, 69.3372, 69.3372, 69.5927 };

            double average = dollarExchangeRate.Average();
            Output($"Среднее значение КВ: {average}");

            double max = dollarExchangeRate.Max();
            Output($"Маскимальное значение КВ: {max}");

            double min = dollarExchangeRate.Min();
            Output($"Минимальное значение КВ: {min}");

            int dayWithMaxER = Array.IndexOf(dollarExchangeRate, max) + 1;
            Output($"День с максимальным значением КВ: {dayWithMaxER} января");

            int dayWithMinER = Array.IndexOf(dollarExchangeRate, min) + 1;
            Output($"День с минимальным значением КВ: {dayWithMinER} января");

            Console.ReadKey();
        }
    }
}
