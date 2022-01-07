using System;
using System.Collections.Generic;
using System.Text;

namespace HMS
{
    abstract class Animal
    {
        public string color = "white";
        public string genus;
        public int age;
        public int pen_no;
        abstract public void move(int n);

    }
}
