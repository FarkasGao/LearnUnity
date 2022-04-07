using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "How are you";
            //str = Change(str);
            //Console.WriteLine(str);
            //string only;
            ////str = Serach(str,out only);
            //Console.WriteLine(str);
            //Console.WriteLine(only);
            str =UseAppend(str);
            Console.WriteLine(str);
        }
        private static string Exchange(string str)//单词反转
        {
            string[] str2 = str.Split(' ');
            Array.Reverse(str2);
            return string.Join("", str2);
        }
        private static string Change(string str)
        {
            char[] c1 = str.ToCharArray();
            Array.Reverse(c1);
            str=string.Join("", c1);
            return str;
        }
        private static string serach(string str)
        {
            StringBuilder stringBuilder = new StringBuilder(str.Length);
            foreach (var item in str)
            {
                if (stringBuilder.ToString().IndexOf(item) < 0)
                    stringBuilder.Append(item);
            }
            return stringBuilder.ToString();
        }
        //private static string Serach(string str,out string only)
        //{
        //    string str2;
        //    char[] c1 = str.ToCharArray();
        //    char[] c2=new char[str.Length];
        //    int n = 0;
        //    only = "";
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        int t = 1;
        //        for (int m = 0; m < n; m++)
        //        {c1.In
        //            if (c1[i].IndexOf(c2[m]) > 0)
        //            {
        //                t = 0;
        //            }

        //        }
        //        if (t == 1) c2[n++] = c1[i];
        //        if (str.IndexOf(c1[i]) == str.LastIndexOf(c1[i]))
        //            only += c1[i];
        //    }
        //    str = string.Join("", c2);
        //    return str;
        //}
        public static string FindNotContainString(string targetString)
        {
            StringBuilder builder = new StringBuilder(targetString.Length);
            foreach (char c in targetString)
            {
                if (builder.ToString().IndexOf(c) == -1)
                    builder.Append(c);
            }
            return builder.ToString();
        }
        private static string UseAppend(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();
            char[] c1 = { 'A', 'B', 'C' };
            for(int i=0;i<3;i++)
            {
                stringBuilder.Append(c1[i]);
            }
            Console.WriteLine(stringBuilder);//ABC
            char[] c2 = { 'D', 'E', 'F' };
            stringBuilder.Append(c2);
            Console.WriteLine(stringBuilder);//ABCDEF
            return str;
        }
    }
}