using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pricePerGallon = 2.35; 
            
            System.Console.WriteLine("Hello World");
            
            string vehicleYear = System.Console.ReadLine();
            
            System.Console.WriteLine("Does the Vehile Use Diesel?");
            
            bool isDiesel = bool.Parse(System.Console.ReadLine());

            System.Console.WriteLine("What is the Vehicle's make?");

            string vehicleMake = System.Console.ReadLine();

            System.Console.WriteLine("What is the Vehicle's model?");

            string vehicleModel = System.Console.ReadLine();

            System.Console.WriteLine("How many MPG's does the Vehicle get?");
            int milesPerGallon = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many gallons are currently in the tank?");
            double numberOfGallons = double.Parse(System.Console.ReadLine());

            double range = milesPerGallon * numberOfGallons;
            
            //  MPG
            //  Gallon Capacity
            //  Current Gallons
            // Diesel (true or false)

            // Range (MPG * Number Gallons)
            // How much it wil cost to fill up tank
            // How much it will cost to completely up tank 

            System.Console.WriteLine("Your current range is " + range);
            System.Console.ReadKey();
         }
    }
}
