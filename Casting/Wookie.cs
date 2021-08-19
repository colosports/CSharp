using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Wookie
    {
        private string _name;

        public string Name
        {
            get { return _name; }
        }


        public  Wookie(string name)
        {
            _name = name;
        }

        public void PilotShip()
        {
            Console.WriteLine("Ship started by " + Name);
        }
    }
}
