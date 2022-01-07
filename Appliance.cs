using System;
using System.Collections.Generic;
using System.Text;

namespace HMS
{
    abstract class Appliance
    {
        public string color = "white";
        public string location;
        abstract public void move(string n);

  /*      public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Location
        {
            get { return location; }
            set { color = value; }
        }*/

    }
}
