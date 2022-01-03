using System;
using System.Collections.Generic;
using System.Text;

namespace HMS
{
    abstract class Appliance
    {
        public string color = "";
        abstract public void move();

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
