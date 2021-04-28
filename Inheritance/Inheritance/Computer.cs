using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Computer
    {
        private string _name;
        private int _processor;
        private int _ram;
        private int _hdd;
        private string _filename;

        public string Name
        {
            get { return _name; }
        }
        public int Processor
        {
            get { return _processor; }
            set { _processor = value; }
        }
        public int Ram
        {
            get { return _ram; }
            set { _ram = value; }
        }
        public int Hdd
        {
            get { return _hdd; }
            set { _hdd = value; }
        }
        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }

        public Computer(string name)
        {
            _name = name;
            _hdd = 2000;
        }
        public Computer(string name, int processor, int ram, int hdd)
        {
            _name = name;
            _hdd = hdd;
            _processor = processor;
            _ram = ram;
            _hdd = hdd;
        }
        public void SaveFile(string filename)
        {
            // TODO: Need to check to ensure Hdd size is >= 1000.
            _filename = filename;
            _hdd = _hdd - 1000;
        }


    }
}
