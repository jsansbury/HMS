using System;

namespace HMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal F1 = new Mammal("cat", 'f', true, 3);
            Console.WriteLine(F1.genus + " created");
            F1.move(26);
            F1.color = "tabby";
            Console.WriteLine("The " + F1.color + " " + F1.genus + " is now in pen " + F1.pen_no);
            F1.pen_no = 36;
            Console.WriteLine("The " + F1.color + " " + F1.genus + " is now in pen " + F1.pen_no);
            
        }
    }
}
