using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    
    internal class Program2
    {
        static void Main6821(string[] args)
        {
            string password = "1485";
            string login = "Vladenceya";
            string userPass;
            string userLog;

            int attemptCount = 3;
            int attempts = 0;
            while (true)
            {

                Console.Write("enter login: ");
                userLog = Console.ReadLine();

                Console.Write("enter password: ");
                userPass = Console.ReadLine();

                if (userLog == login && userPass == password)
                {
                    Console.WriteLine("Welcome User!");
                        break;
                }
                else if (userLog == login)
                {
                    Console.WriteLine("wrong password!");
                }
                else if (userPass == password)
                {
                    Console.WriteLine("wrong login!");
                }
                else
                {
                    Console.WriteLine("wrong login and password");
                }
                attempts++;

                if (attempts >= attemptCount)
                {
                    Console.WriteLine("your account is blocked");
                    break;
                }


            }
            

        }
    }
}
