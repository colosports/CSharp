using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            var wookie = new Wookie("Chewbacca");
            var ewok = new Ewok ("Chirpa");

            void FlyShip(Wookie w1)
            {
                w1.PilotShip();
            }
            FlyShip(wookie);

            void MakeClothes(Ewok e1)
            {
                e1.MakeClothes();
            }
            MakeClothes(ewok);
        }
    }
}
