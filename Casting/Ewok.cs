using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Ewok : Wookie
    {
        public Ewok(string name) : base(name);
        {
            Name = Wookie.Name;
            MakeClothes();
        }

        public void MakeClothes()
        {
            Console.WriteLine(Name + " just finished your clothes");
        }

    }
}
