using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    class Wife
    {
        private string name;
        private int age;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 40 && value >= 18)
                    this.age = value;
                else throw new Exception("wrong age");
            }
        }
        public Wife(string name,int age)
        {
            this.name = name;
            this.Age = age;
        }
    }
}
