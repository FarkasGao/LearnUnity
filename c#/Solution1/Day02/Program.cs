using System;

namespace Day02
{
    class Program
    {
        static void Main1(string[] args)
        {
            string str = string.Format("money:{0:c},{1:d2}", 10, 5);
            Console.WriteLine(str);
            Console.WriteLine("{0:f1}",1.26);
            Console.WriteLine("{0:p}", 0.1);
            Console.WriteLine("{0:p0}", 0.1);
            Console.WriteLine("{0:p1}",0.1);
            Console.WriteLine("check \" it");
            char c = '\0';
            Console.WriteLine(c);
            Console.WriteLine("hello,\r\nnice to meet you");
            Console.WriteLine("here are\ta blank");
        }
        static void Main2()
        {
            string str01 = 1 > 2 ? "yes" : "no";
            Console.WriteLine(str01);
            float m = 1 > 2 ? 1.2f : 1.3f;
            float n = 10 % 3*2;
        }
        static void Main3()
        {
            byte b = 255;
            b += 3;
            b = (byte)(b + 3);
        }
        static void Main4()
        {
            Console.WriteLine("Please enter any month");
            int day;
            string month = Console.ReadLine();
            switch(month)
            {
                case "1":
                case "3":
                case "5":
                case "7":
                case "8":
                case "10":
                case "12":
                    day = 31;break;
                case "4":
                case "6":
                case "9":
                case "11":
                    day = 30;break;
                case "2":
                    day = 28;break;
                default:
                    day = 00;break;
            }
            if (day == 00) Console.WriteLine("the number is wrong");
            else Console.WriteLine("{0} month have {1} days",month,day);
        }
        static void Main()
        {
            Console.WriteLine("Please enter you salary:");
            double tax;
            string salaryNumber = Console.ReadLine();
            int salary = int.Parse(salaryNumber);
            if (salary < 4000) tax = 0;
            else if (salary <= 5500) tax = (salary - 4000) * 0.03;
            else if (salary <= 8500) tax = (salary - 4000) * 0.1 - 105;
            else if (salary <= 13000) tax = (salary - 4000) * 0.2 - 555;
            else if (salary <= 39000) tax = (salary - 4000) * 0.25 - 1005;
            else if (salary <= 59000) tax = (salary - 4000) * 0.3 - 2755;
            else if (salary <= 84000) tax = (salary - 4000) * 0.35 - 5505;
            else tax = (salary - 4000) * 0.45 - 13505;
            Console.WriteLine("The tax is {0}",tax);
        }
    }
}
