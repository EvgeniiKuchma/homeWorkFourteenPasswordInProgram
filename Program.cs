using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkFourteenPasswordInProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counteTries = 0;
            int maxTries = 3;

            bool isWorking = true;

            string password = "qwerty";

            string userInput;

            while (counteTries < maxTries && isWorking)
            {
                Console.Write("Please enter the password: ");
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine("TOP SECRET INFO COD ---0000--- , ONLY STUFF USELESS");
                    isWorking = false;
                }
                else
                {
                    Console.WriteLine("INvalid PASSWORD. try again.");
                    counteTries++;
                }
            }
        }
    }
}
