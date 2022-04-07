using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    [Flags]
    enum PersonStyle
    {
        beauty=1,//00000001
        handsome=2,//00000010
        rich=4,//00000100
        tall=8,//00001000
        white=16,//00010000
    }
    class Program
    {
        static void Main01(string[] args)
        {
            PrintPersonStyle(PersonStyle.beauty | PersonStyle.handsome);
            int enumNumber = (int)(PersonStyle.beauty | PersonStyle.handsome);
            Console.WriteLine((int)(PersonStyle.beauty | PersonStyle.handsome));
            PersonStyle style02=(PersonStyle)Enum.Parse(typeof(PersonStyle), "beauty");
        }
        private static void PrintPersonStyle(PersonStyle style)
        {
            if ((style & PersonStyle.beauty) == PersonStyle.beauty) Console.WriteLine("beauty");
            if ((style & PersonStyle.handsome) == PersonStyle.handsome) Console.WriteLine("handsome");
            if ((style & PersonStyle.rich) != 0) //或者
                Console.WriteLine("rich");
            if ((style & PersonStyle.tall) != 0) 
                Console.WriteLine("tall");
            if ((style & PersonStyle.white) != 0) 
                Console.WriteLine("white");
        }
        static void Main()
        {
            User u1 = new User("111", "122");
            User u2 = new User("222", "222");
            User u3 = new User("333", "322");
            User u4 = new User("444", "422");
            UserList user = new UserList(2);
            user.Add(u1);
            Console.WriteLine(user.Count);
            user.Add(u2);
            Console.WriteLine(user.Count);
            user.Add(u3);
            Console.WriteLine(user.Count);
            user.Add(u4);
            Console.WriteLine(user.Count);
            user.Delete(2);
            Console.WriteLine(user.GetUser(1).LoginID);
            Console.WriteLine(user.GetUser(2).LoginID);

            //c# 泛型 集合      List<数据类型>
            List<User> users = new List<User>(10);
            users.Add(u1);
            users.Add(u2);
            for (int i = 0; i < users.Count; i++)
            {
                User user1 = users[i];
                Console.WriteLine(user1.LoginID);
                Console.WriteLine(user1.Password);
            }
            Dictionary<string, User> dic = new Dictionary<string, User>();
            dic.Add("1", u1);
            dic.Add("gy", new User("gy", "123456"));
            User user2 = dic["1"];
            Console.WriteLine(user2.Password);
            Console.WriteLine(user2.LoginID);
        }
        private static Wife GetMinWife()
        {
            Wife[] wifeArray = new Wife[5];
            wifeArray[0] = new Wife("01", 18);
            wifeArray[1] = new Wife("02", 19);
            wifeArray[2] = new Wife("03", 20);
            wifeArray[3] = new Wife("04", 24);
            wifeArray[4] = new Wife("05", 18);
            Wife minWife = wifeArray[0];
            for (int i = 0; i < wifeArray.Length; i++)
            {
                if (minWife.Age > wifeArray[i].Age)
                {
                    minWife = wifeArray[i];
                }
            }
            return minWife;
        }
    }


}
