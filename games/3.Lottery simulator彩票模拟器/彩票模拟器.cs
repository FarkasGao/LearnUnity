using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "彩票模拟器";
            Console.WriteLine("Please enter random number for six times");
            int[] number = new int[7];
            number= GetRedNumber();
            int[] ran_number = RandomNumber();
            int t = 0;
            int y = 0;
            foreach (var item in ran_number)
            {
                Console.Write(item+" ");
            }
            for(int i=0;i<7;i++)
            {
                if (number[6] == ran_number[6]) y=1;
                if (Array.IndexOf(ran_number, number[i]) >=0) t++;
            }
            Console.WriteLine("");
            if (t + y == 7) Console.WriteLine("congratulations!You win the frist prize!The bonos is 100 million yuan!");
            else if (t == 6) Console.WriteLine("congratulations!You win the second prize!The bonos is 25 million yuan!");
            else if (t + y == 6) Console.WriteLine("congratulations!You win the third prize!The bonos is 3000 yuan!");
            else if (t + y == 5) Console.WriteLine("congratulations!You win the fourth prize!The bonos is 200 yuan!");
            else if (t + y == 4) Console.WriteLine("congratulations!You win the fifth prize!The bonos is 10 yuan!");
            else if (y == 1) Console.WriteLine("congratulations!You win the sixth prize!The bonos is 5 yuan!");
            else Console.WriteLine("sorry,you didn't win");
        }
        private static int[] GetRedNumber()
        {
            int[] number = new int[7];
            for (int i = 0; i < 6; i++)
            {
                string str_number = Console.ReadLine();
                int m = Array.IndexOf(number, int.Parse(str_number));
                if (m < 0)
                {
                    number[i] = int.Parse(str_number);
                    if (number[i] < 1 || number[i] > 33)
                    {
                        Console.WriteLine("The number no more than 1~33");
                        i--;
                    }
                }
                else
                {
                    i--;
                    Console.WriteLine("You input the same number");
                }
            }
            number[6] = GetBlueNumber();
            return number;
        }
        private static int GetBlueNumber()
        {
            int number=0;
            for (int i = 0; i <1; i++)
            {
                string str_number = Console.ReadLine();
                number = int.Parse(str_number);
                if (number < 1 || number > 16)
                {
                    Console.WriteLine("The number no more than 1~17");
                    i--;
                }
            }
            return number;
        }
        private static int[] RandomNumber()
        {
            int[] number = new int[7];
            int x = 0;
            for (int i = 0; i < 6; i++)
            {
                x=random.Next(1, 34);
                if (Array.IndexOf(number, x) <0) number[i] = x;
                else i--;
            }
            number[6] = 100;
            Array.Sort(number);
            number[6] = random.Next(1, 17);
            return number;
        }
        static Random random = new Random();
    }
}
