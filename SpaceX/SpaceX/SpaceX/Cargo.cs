using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceX
{
    class Cargo
    {
        private float _pounds; //default is set to 0.0
        private int _doors; //default is set to 0
        private bool _loaded; //default is set to false

        public float pounds
        {
            get { return _pounds; }
            set { 
               if (value > 500)
                {
                    throw new Exception("Maximum weight exceeded.");
                }
                _pounds = value;
             }
        }
        public int doors
        {
            get { return _doors;  }
            set { _doors = value; }
        }
        public bool loaded
        {
            get { return _loaded; }
            set { _loaded = value; }
        }

    }
}
