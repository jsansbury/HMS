using System;

namespace HMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Refrigerator F1 = new Refrigerator("Zanussi");
            Console.WriteLine(F1.app_name + " created");
            F1.move("living room");
            F1.color = "red";
            Console.WriteLine("The " + F1.color + " " + F1.make + " " + F1.app_name + " is now in the " + F1.location);
            F1.location = "conservatory";
            Console.WriteLine("The " + F1.color + " " + F1.make + " " + F1.app_name + " is now in the " + F1.location);
            
        }
    }
}
