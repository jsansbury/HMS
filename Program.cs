using System;

namespace HMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Refrigerator F1 = new Refrigerator("Zanussi");
            Console.WriteLine(F1.app_name + " created in " + F1.location);
            F1.move();
            //F1.color = "red";
            F1.location = "living room";
            F1.guarantee();
           // Console.WriteLine("The "+ F1.color + " " + F1.app_name + " is now in " + F1.location);
            Console.WriteLine("The " + F1.app_name + " is now in " + F1.location);
        }
    }
}
