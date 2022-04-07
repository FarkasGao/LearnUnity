using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "猜数字";
            Random random = new Random();
            int number = random.Next(1, 101);
            int i = 0;
            int numberP;
            Console.WriteLine("Please enter a random number:");
            do
            {
                i++;
                string numberPlayer = Console.ReadLine();
                numberP = int.Parse(numberPlayer);
                if (number < numberP) Console.WriteLine("Lagar than number\r\nTry again:");
                else if (number > numberP) Console.WriteLine("Smaller than number\r\nTry again:");
                else Console.WriteLine("congraculation!You are right,you tried {0} times", i);
            } while (number != numberP);
        }
    }
}