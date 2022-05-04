using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car - DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() - DONE
            //The methods should take one string parameter: the respective noise property - DONE


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            

            Console.WriteLine("We're going to show you 3 different cars and some info about them, and you let me know which you like ok?");
            Console.WriteLine();
            Console.ReadLine();
            Console.ReadKey();

            Console.WriteLine("Whatever, let's get this over with");
            Console.ReadKey();

            Console.WriteLine("*Clears throat*");
            Console.ReadKey();


            Console.WriteLine("First off!");
            Console.ReadKey();



            Car hondaCivic = new Car()
            {
                Year = 2019,
                Make = "Honda",
                Model = "Civic",
                EngineNoise = "Vroom vroom",
                HonkNoise = "Beep beep",
                IsDriveable = "Yes",
                
            };
            CarLot.numberOfCars = 6;

            Console.WriteLine($"We have the {hondaCivic.Year} {hondaCivic.Make} {hondaCivic.Model}!");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine($"Is it driveable? {hondaCivic.IsDriveable}");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("It also has an engine that goes");
            Console.ReadKey();
            Car.MakeEngineNoise(hondaCivic.EngineNoise);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("And a horn that goes");
            Console.ReadKey();
            Car.MakeHonkNoise(hondaCivic.HonkNoise);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("We currently have " + CarLot.numberOfCars + " on the lot");

            Console.ReadKey();

            Car bmw3series = new Car()
            {
                Year = 2006,
                Make = "BMW",
                Model = "330 xi",
                EngineNoise = "boomboomboombbrrrr-lskdjfhgliusd *engine knocking sounds*",
                HonkNoise = "bipbipbipbipbip",
                IsDriveable = "Welll, it depends on what you mean by driveable",

            };
            CarLot.numberOfCars++;

            Console.WriteLine($"Next up! Here we have the {bmw3series.Year} {bmw3series.Make} {bmw3series.Model}!");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine($"Is it driveable? {bmw3series.IsDriveable}");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("It also has an engine that goes");
            Console.ReadKey();
            Car.MakeEngineNoise(bmw3series.EngineNoise);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("And a horn that goes");
            Console.ReadKey();
            Car.MakeHonkNoise(bmw3series.HonkNoise);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("We currently have " + CarLot.numberOfCars + " that have been sitting around for a while");
            Console.ReadKey();


            Car toyotaCorolla = new Car()
            {
                Year = 2012,
                Make = "Toyota",
                Model = "Corolla",
                EngineNoise = "Vroooommmmvroomvroomvroomvroom",
                HonkNoise = "Honk Honk Honkkk",
                IsDriveable = "This thing has 160k miles on it as we speak and will literally outlive us all",

            };
            CarLot.numberOfCars++;

            Console.WriteLine($"And last but certainly not least, is the {toyotaCorolla.Year} {toyotaCorolla.Make} {toyotaCorolla.Model}!");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine($"Is it driveable? {toyotaCorolla.IsDriveable}");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("It also has an engine that goes");
            Console.ReadKey();
            Car.MakeEngineNoise(toyotaCorolla.EngineNoise);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("And a horn that goes");
            Console.ReadKey();
            Car.MakeHonkNoise(toyotaCorolla.HonkNoise);
            Console.WriteLine();
            Console.ReadKey();

            
            Console.WriteLine("We had 22 at the beginning of the week! But we only have " + CarLot.numberOfCars + " left");
            Console.ReadKey();


            Console.WriteLine("Now which will you take home with you today? A,B, or C?");

            string choice = Console.ReadLine();

            if (choice == "Honda" || choice == "Civic" || choice == "The Honda" || choice == "The Civic" || choice == "The Honda Civic" ||
                choice == "Honda Civic")

            {
                Console.WriteLine("Nice! Let's go and run your application");
                Console.ReadKey();

            }

            if (choice == "BMW" || choice == "330xi" || choice == "The BMW" || choice == "The 330xi" || choice == "The BMW 330xi" ||
                choice == "BMW 330xi") 

            {
                Console.WriteLine("I don't think this is the wisest choice boss, this car will cost you more in maintenance and upkeep than it's worth.");
                Console.ReadKey();
            }

            if (choice == "Toyota" || choice == "Corolla" || choice == "The Toyota" || choice == "The Corolla" || choice == "The Toyota Corolla" ||
                choice == "Toyota Corolla")

            {
                Console.WriteLine("A solid choice! This thing will last you forever.");
                Console.ReadKey();
            }

            
            






            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
