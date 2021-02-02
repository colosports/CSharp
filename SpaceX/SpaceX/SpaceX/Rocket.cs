using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX
{
    class Rocket
    {
        private int _fuel;
        private string _name;
        public List<Cargo> _cargo = new List<Cargo>();

        public float CargoWeight()
        {
            float totalWeight = 0;
            foreach (Cargo cargo in _cargo)
            {
                totalWeight += cargo.pounds;
            }
            return totalWeight;
        }

    }
}
