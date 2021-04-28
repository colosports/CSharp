using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Computer name (required):");
            var Name = Console.ReadLine();
            Console.WriteLine("Processor size (32 or 64):");
            var Processor = Console.ReadLine();
            Console.WriteLine("RAM size:");
            var Ram = Console.ReadLine();
            Console.WriteLine("HDD size:");
            var Hdd = Console.ReadLine();
            Console.WriteLine("Is the device a Laptop (yes or no) [yes]: ");            
            var Laptop = Console.ReadLine();
            var IsLaptop = true;
            if (Laptop == "no")
                IsLaptop = false;
            else
                IsLaptop = true;
            */

            //var tyLaptop = new Laptop();
            //tyLaptop.Name = "Dell";

            var tyDesktop = new Computer("Lenovo");
            tyDesktop.SaveFile("File1");
            Console.WriteLine("{0} has {1} MB remaining", tyDesktop.Name, tyDesktop.Hdd);

            var tyDesktop2 = new Computer("HP",64,3000,40000);
            tyDesktop2.SaveFile("File1");
            tyDesktop2.SaveFile("File2");
            Console.WriteLine("{0} has {1} MB remaining", tyDesktop2.Name, tyDesktop2.Hdd);

            var tyLaptop = new Laptop("Dell");
            tyLaptop.Processor = 64;
            tyLaptop.Ram = 2000;
            tyLaptop.Hdd = 100000;
            tyLaptop.Portable = true;
            tyLaptop.SaveFile("File1");
            Console.WriteLine("{0} has {1} remaining", tyLaptop.Name, tyLaptop.Hdd );
            Console.WriteLine(tyLaptop.ToString());

        }
    }
}
