using System;
using System.Collections.Generic;
using System.Text;

namespace Stopwatch
{
    class Stopwatch
    {
        public DateTime startTime;
        public DateTime stopTime;
        private Boolean _started  = false;

        public TimeSpan Duration
        {
            get { return (stopTime - startTime);  }
        }

        public void Start()
        {
            if (_started == false)
            {
                startTime = DateTime.Now;
                _started = true;
            }
            else
            {
                throw new InvalidOperationException();                   
            }
        }

        public void Stop()
        {
            stopTime = DateTime.Now;
            _started = false;
        }


    }
}
