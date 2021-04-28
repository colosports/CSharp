using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Human
    {
        private string _name;
        protected string _DNA = Guid.NewGuid().ToString();

        public string Name
        {
            get { return _name; }
        }
        public string DNA
        {
            get { return _DNA; }
        }

        public Human(string name)
        {
            _name = name;
            //Console.WriteLine("{0}'s DNA is: {1}", name, _DNA);
        }
    }
}
