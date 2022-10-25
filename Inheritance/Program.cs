using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // DONE Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var hawk = new Bird();
            hawk.Age = 5;
            hawk.BeakLength = 2.0;
            hawk.WingColor = "Blue";

            var lizard = new Reptile()
            {
                Age = 2,
                CanGrowTail = true,
                LegCount = 4,
                Habitat = "desert",
            };

            Console.WriteLine("Hawk:");
            Console.WriteLine($"Alive: {hawk.IsAlive}");
            Console.WriteLine($"Age: {hawk.Age}");
            Console.WriteLine($"Legs: {hawk.LegCount}");
            Console.WriteLine($"Land, Sea, or Air: {hawk.LandSeaAir}");
            Console.WriteLine($"Wing Color: {hawk.WingColor}");
            Console.WriteLine($"Can Fly: {hawk.CanFly}");
            Console.WriteLine($"Migrates: {hawk.DoMigrate}");
            Console.WriteLine($"Beak Length: {hawk.BeakLength}");

            Console.WriteLine("-----------------");

            Console.WriteLine("Lizard:");
            Console.WriteLine($"Alive: {lizard.IsAlive}");
            Console.WriteLine($"Age: {lizard.Age}");
            Console.WriteLine($"Legs: {lizard.LegCount}");
            Console.WriteLine($"Land, Sea, or Air: {lizard.LandSeaAir}");
            Console.WriteLine($"Cole Blooded: {lizard.IsColdBlooded}");
            Console.WriteLine($"Scales: {lizard.IsScaly}");
            Console.WriteLine($"Habitat: {lizard.Habitat}");
            Console.WriteLine($"Can regrow tail: {lizard.CanGrowTail}");
        }
    }
}
