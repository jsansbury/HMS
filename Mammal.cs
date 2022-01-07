using System;
using System.Collections.Generic;
using System.Text;

namespace HMS
{
    class Mammal : Animal
    {
        public char gender;
        public Boolean swims;

        public Mammal(string gn, char gd, Boolean s, int a)
        {
            genus = gn;
            gender = gd;
            swims = s;
            age = a;
        }

        public override void move(int n)  // override required
        {
            this.pen_no = n;
            Console.WriteLine("being moved to " + n);
        }

    }
}

