using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Clone : Human
    {
        public Clone(string name, Human human) : base(name)
        {
            base._DNA = human.DNA;
        }
    }
}
