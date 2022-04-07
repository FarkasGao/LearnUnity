using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    /// <summary>
    /// 用户类
    /// </summary>
    class User
    {
        public string LoginID { get; set; }
        public string Password { get; set; }
        //自动属性 包含1个字段 2方法
        public User()
        {

        }
        public User(string loginID,string password)
        {
            this.LoginID = loginID;
            this.Password = password;
        }
        public void PrintUser()
        {
            Console.WriteLine("请输入账号密码");
        }

    }
    class UserList
    {
        //字段
        private int value;
        private User[] date = null;
        private int i = 0;
        //输出
        public int Count
        {
            get
            {
                return i;
            }
        }
        //构造函数
        public UserList():this(10)
        {

        }
        public UserList(int value)
        {
            date = new User[value];
            this.value = value;
        }
        //方法
        public void Add(User user)
        {
            if (i >= value)
            {
                AddArrayLength();
            }
            this.date[i++] = user;
        }

        private void AddArrayLength()
        {
            User[] date2 = new User[date.Length * 2];
            date.CopyTo(date2, 0);
            date = date2;
        }

        public User GetUser(int index)
        {
            return date[index];
        }
        public void Input(User user,int index)
        {
            AddArrayLength();
            i = i + 1;
            for (; i > index; i--)
                date[i] = date[i - 1];
            date[index] = user;
        }
        public void Delete(int index)
        {
            for (; index<i; index++)
                date[index] = date[index + 1];
        }

    }
}
