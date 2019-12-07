using System;

namespace exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сделайте свою ставку");
            int rate = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int value = rnd.Next(1, 12);
            Console.WriteLine("Бросаем кубик");
            Console.WriteLine($"Выпало значение, {value}");
            if (value <=5)
            {
                Console.WriteLine("вы проиграли");
            }
            else if (value >5 && value <= 8)
            {
                Console.WriteLine($"Вы выиграли, {rate}");
            }
            else if (value > 8 && value <=11)
            {
                Console.WriteLine($"Вы выиграли, {rate*2}");
            }
            else
            {
                Console.WriteLine($"Вы выиграли, {rate * 10}");
            }

        }
    }
}
