using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "my gun";
            Console.WriteLine("Please enter the name of gun");
            string gunName = Console.ReadLine();
            Console.WriteLine("Please enter the cartridge capacity");
            string gunCartridge = Console.ReadLine();
            Console.WriteLine("Please enter the number of bullets in the current magazine");
            string gunMagazineBullets = Console.ReadLine();
            Console.WriteLine("Please enter the number of bullets left");
            string gunLeftBullets = Console.ReadLine();
            Console.Write("The name of gun is:" + gunName + ",");
            Console.Write("The cartridge capacity is:" + gunCartridge + ",");
            Console.Write("The number of bullets in the magazine is:" + gunMagazineBullets + ",");
            Console.Write("the number of bullets left is:" + gunLeftBullets);
            Console.ReadLine();
        }
    }
}
