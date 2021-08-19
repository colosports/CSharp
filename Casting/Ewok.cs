using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Ewok : Wookie
    {
        public Ewok(string name) : base(name)
        {
            //pass
        }

        public void MakeClothes()
        {
            Console.WriteLine(base.Name + " just finished your clothes");
        }

    }
}
