using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingKata
{
    class TacoBell : ITrackable
    {
        public TacoBell()
        {
        }

        public TacoBell(string name, Point location)
        {
            Name = name;
            Location = location;
        }

        public string Name { get; set; }
        public Point Location { get; set; }
    }
}
