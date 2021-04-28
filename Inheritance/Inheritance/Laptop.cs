using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Laptop : Computer
    {
        public bool Portable { get; set; }

        public Laptop(string name) : base(name) 
        {
            Portable = true;
        }

        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine("Name: " + this.Name);
            text.AppendLine("HDD: " + this.Hdd);
            return text.ToString();
        }
    }
}
