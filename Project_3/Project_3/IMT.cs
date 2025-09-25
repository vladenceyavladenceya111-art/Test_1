using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    internal class IMT
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Калькулятор Индекса Массы Тела (ИМТ)---\n");
            Console.WriteLine("Введите ваш рост в метрах (например 1,75): ");
            string height = Console.ReadLine();

            Console.WriteLine("Введите ваш вес в килограммах: \n");
            string weight = Console.ReadLine();

            float weightint = Convert.ToSingle(weight);
            float heightint = Convert.ToSingle(height);

            float IMT = weightint / (heightint * heightint);

            Console.WriteLine("---Ваш результат--- ");
            Console.WriteLine(IMT);






        }
    }
}
