using System;

namespace lab_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double y, b, a, x;
                Console.WriteLine("Ввести (y) Прибыль:");
                y = double.Parse(Console.ReadLine());
                Console.WriteLine("Ввести (b) Себестоимость:");
                b = double.Parse(Console.ReadLine());
                a = (b / 100) * 105;
                x = ((y / a) / 100) * 100;
                Console.WriteLine("Рентабельность:x={0:F2}", ((y / a) / 100) * 100);
            }
            catch
            {
                Console.WriteLine("Введите корректно прибыль и себестоимость");
            }
            
        }
    }
}
