using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    class Program
    {
        static void Main01()
        {
            Console.Title = "Calendar";
            Console.WriteLine("Please input the calendar of the yeaar you want to query:");
            string year=Console.ReadLine();
            int intYear = int.Parse(year);
            int month = 0;
            for (month = 1; month< 13; month++)
            {
                Console.WriteLine("\r\n\r\n{0}年{1}月:",year,month);
                MonthCalendar(month,intYear);
            }
        }
        private static void MonthCalendar(int month,int year)
            {
            string chart = "日\t一\t二\t三\t四\t五\t六";
            Console.WriteLine(chart);
            int day = GetDayByMonth(month, year);
            int week = GetWeekByDay(year, month, day);
            switch (week)
            {
                case 7: break;
                case 1: Console.Write(" \t"); break;
                case 2: Console.Write(" \t \t"); break;
                case 3: Console.Write(" \t \t \t"); break;
                case 4: Console.Write(" \t \t \t \t"); break;
                case 5: Console.Write(" \t \t \t \t \t"); break;
                case 6: Console.Write(" \t \t \t \t \t \t"); break;
            }
            for (int i=1;i<=day;i++)
            {
                if (i < 10) Console.Write(" ");
                Console.Write(i);
                if ((week + i) % 7 == 0) Console.WriteLine();
                else Console.Write("\t");
                if (i == day) Console.WriteLine();
            }
            }
        /// <summary>
        /// 根据年月，计算每月有多少天
        /// </summary>
        /// <param name="month">月</param>
        /// <param name="year">年</param>
        private static int GetDayByMonth(int month,int year)
        {
            int day=0;
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:day = 31;break;
                case 4:
                case 6:
                case 9:
                case 11:day = 30;break;
                case 2:day = 28;
                    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                        day = day + 1;break;
            }
            return day;
        }
        /// <summary>
        /// 根据年月日，计算星期数的方法
        /// </summary>
        /// <param name="year">年份</param>
        /// <param name="month">月份</param>
        /// <param name="day">天</param>
        /// <returns>星期</returns>
        private static int GetWeekByDay(int year,int month,int day)
        {
            DateTime dt = new DateTime(year, month, day);
            return (int)dt.DayOfWeek;
        }
        static void Main()
        {
            string str_Day = Console.ReadLine();
            string str_Hour = Console.ReadLine();
            string str_Mintue = Console.ReadLine();
            int day = int.Parse(str_Day);
            int hour = int.Parse(str_Hour);
            int mintue = int.Parse(str_Mintue);
            int second = 0;
            hour += DayToHour(day);
            mintue += HourToMintue(hour);
            second += MintueToSecond(mintue);
            Console.WriteLine(second);
        }
        private static int DayToHour(int day)
        {
            return 24 * day;
        }
        private static int HourToMintue(int hour)
        {
            return 60 * hour;
        }
        private static int MintueToSecond(int mintue)
        {
            return 60 * mintue;
        }
    }
}