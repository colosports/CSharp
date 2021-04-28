using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            var human = new Human("Jango Fett");
            var clone = new Clone("Boba Fett", human);
            var jedi = new Human("Luke Skywalker");

            Console.WriteLine("{0} DNA: {1}", human.Name, human.DNA);
            Console.WriteLine("{0} DNA: {1}", clone.Name, clone.DNA);
            Console.WriteLine("{0} DNA: {1}", jedi.Name, jedi.DNA);
        }
    }
}
