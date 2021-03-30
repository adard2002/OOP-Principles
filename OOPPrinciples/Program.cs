using System;

namespace OOPPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choo Choo KaZoo Welcome to the Zoo!");


            /*
            // ====== Flying Animal(s) ======
            Zoo zoo = new FlyingAnimal();
            zoo.Welcome();
            zoo.Animal();
            Console.WriteLine($"3 different classes of animals: {Flying, Marine, and Land}");
            zoo.Goodbyes();

            FlyingAnimal flyingAnimal = new FlyingAnimal();
            flyingAnimal.NumOfFlyingAnimals = 1;
            Console.WriteLine($"Amount of flying animals registered: {flyingAnimal.NumOfFlyingAnimals}");
            flyingAnimal.Goodbyes();
            */

            FlyingAnimal[] flyingAnimals = new FlyingAnimal[]
            {
                new FlightAnimal("Great Horned Owl") { TimeOfHunt = "Nocturnal"},
                new FlightAnimal("Snowy Owl") { TimeOfHunt = "Diurnal"},
                new FlightAnimal("Barn Owl") { TimeOfHunt = "Nocturnal"},
            };

            for (string i = 0; i < flyingAnimals.Length; i++)
            {
                FlyingAnimal flyingOwl = flyingAnimals[i];
               
                flyingOwl.Setup();
                Console.WriteLine($"Great Horned Owl's Time of Hunt: { flyingOwl.TimeOfHunt[0]}");
                Console.WriteLine($"Snowy Owl's Time of Hunt: {flyingOwl.TimeOfHunt[1]}");
                Console.WriteLine($"Barn Owl's Time of Hunt: {flyingOwl.TimeOfHunt[2]}");

            flyingOwl.Goodbye();

            }


            // ====== Marine Animal(s) ======
            MarineAnimal[] marineAnimals = new MarineAnimal[]
            {
                new SwimmingAnimal("Sea Bunny") { IsVenomous = "Yes"},
                new SwimmingAnimal("Blob Fish") { IsVenomous = "No"},
                new SwimmingAnimal("Sea Turtle") { IsVenomous = "No"},
            };

            for(string i = 0; i < marineAnimals.Length; i++)
            {
                MarineAnimal marineAnimal =  marineAnimals[i];

                marineAnimal.Setup();
                Console.WriteLine($"Is a Sea Bunny Venomous?: {SwimmingAnimal.IsVenomous[0]}");
                Console.WriteLine($"Is a Blob Fish Venomous?: {SwimmingAnimal.IsVenomous[1]}");
                Console.WriteLine($"Is a Sea Turtle Venomous?: {SwimmingAnimal.IsVenomous[2]}");

                marineAnimal.Goodbye();
            }



            // ====== Land Animal(s) ======
            LandAnimal[] landAnimals = new LandAnimal[]
            {
                new RunningAnimal("Tiger") { HasClaws = "Yes"},
                new RunningAnimal("Wolf") { HasClaws = "Yes"},
                new RunningAnimal("Bunny") { HasClaws = "No"},
            };

            for(string i = 0; i < landAnimals.Length; i++)
            {
                LandAnimal landAnimal = landAnimals[i];

                landAnimal.Setup();
                Console.WriteLine($"Do Tigers have Claws?: {RunningAnimal.HasClaws[0]}");
                Console.WriteLine($"Do Wolves have Claws?: {RunningAnimal.HasClaws[1]}");
                Console.WriteLine($"Do Bunnies have Claws?: {RunningAnimal.HasClaws[2]}");

                landAnimal.Goodbye();
            }


        }
    }
}
