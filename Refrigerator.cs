using System;
using System.Collections.Generic;
using System.Text;

namespace HMS
{
    class Refrigerator : IGuarantee
    {
        public string app_name;
        public string location;
        public string make;
        public Refrigerator(string m)
        {
            app_name = "Refrigerator";
            location = "Kitchen";
            make = m;
        }

        public string App_name
        {
            get { return app_name; }
            set { app_name = value; }
        }
        public  void move()  // override removed now 
        {
            Console.WriteLine("being moved");
        }

        public void guarantee()
        {
            Console.WriteLine("This applicance is under guarantee");
        }
    }
}

