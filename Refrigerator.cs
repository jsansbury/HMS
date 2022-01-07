using System;
using System.Collections.Generic;
using System.Text;

namespace HMS
{
    class Refrigerator : Appliance
    {
        public string app_name;
        public string make;

        public Refrigerator(string m)
        {
            app_name = "Refrigerator";
            make = m;
        }

        public override void move(string n)  // override required
        {
            this.location = n;
            Console.WriteLine("being moved to " + n);
        }

        public void guarantee()
        {
            Console.WriteLine("This appliance is under guarantee");
        }
    }
}

