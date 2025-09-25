using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    internal class Program
    {
        static void Main1234(string[] args)
        {

            Console.WriteLine("enter any year:");
            string sourceYear = Console.ReadLine();

            int year = Convert.ToInt32(sourceYear);

            if (year % 4 == 0 && year % 4 == 100)
            {
                Console.WriteLine("not a leap year (");

            }

            else if (year % 4 == 400)
            {
                Console.WriteLine("it's a leap year )");
            }

            else if (year % 4 == 0)
            {
                Console.WriteLine("it's a leap year )");
            }
            else
            {
                Console.WriteLine("not a leap year (");
            }

        }
    }
}
