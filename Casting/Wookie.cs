using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Wookie
    {
        public string Name;
        
        public  Wookie(string name)
        {
            Name = name;
        }

        public void PilotShip()
        {
            Console.WriteLine("Ship started by" + Name);
        }
    }
}
