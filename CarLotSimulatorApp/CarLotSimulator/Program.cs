using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            //above completed in Car.cs

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            CarLot parkAndFly = new CarLot();

            var car1 = new Car();
            Console.WriteLine($"Car # {CarLot.numberOfCars} was just created.");
            car1.Year = 2021;
            car1.Make = "Honda";
            car1.Model = "Pilot";
            car1.EngineNoise = "Hummmmmm";
            car1.HonkNoise = "HONK!HONK!";
            car1.IsDriveable = true;

            parkAndFly.CarList.Add(car1);

            var car2 = new Car();
            Console.WriteLine($"Car # {CarLot.numberOfCars} was just created.");
            car2.Year = 2022;
            car2.Make = "Accura";
            car2.Model = "DX";
            car2.EngineNoise = "BRUmmmmm";
            car2.HonkNoise = "HONK!BEEP!";
            car2.IsDriveable = true;

            parkAndFly.CarList.Add(car2);

            var car3 = new Car();
            Console.WriteLine($"Car # {CarLot.numberOfCars} was just created.");
            car3.Year = 2019;
            car3.Make = "Kia";
            car3.Model = "Soul";
            car3.EngineNoise = "Putputput";
            car3.HonkNoise = "beepbeep";
            car3.IsDriveable = true;

            parkAndFly.CarList.Add(car3);

            Console.WriteLine($"Sounds of your {car1.Year} {car1.Make} {car1.Model}");
            Console.Write("The engine sounds like ");
            car1.MakeEngineNoise(car1.EngineNoise);
            Console.Write("The horn sounds like ");
            car1.MakeHonkNoise(car1.HonkNoise);
            Console.WriteLine("-----------------------");

            Console.WriteLine($"Sounds of your {car2.Year} {car2.Make} {car2.Model}");
            Console.Write("The engine sounds like ");
            car2.MakeEngineNoise(car2.EngineNoise);
            Console.Write("The horn sounds like ");
            car2.MakeHonkNoise(car2.HonkNoise);
            Console.WriteLine("-----------------------");

            Console.WriteLine($"Sounds of your {car3.Year} {car3.Make} {car3.Model}");
            Console.Write("The engine sounds like ");
            car3.MakeEngineNoise(car3.EngineNoise);
            Console.Write("The horn sounds like ");
            car3.MakeHonkNoise(car3.HonkNoise);
            Console.WriteLine("-----------------------");


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            Car car1Type2 = new Car() { Year = 1953, Make = "Ford", Model = "Thunderbird", EngineNoise = "GRRRR", HonkNoise = "HONK", IsDriveable = true };
            Console.WriteLine($"Car # {CarLot.numberOfCars} was just created.");
            parkAndFly.CarList.Add(car1Type2);

            Car car1Type3 = new Car(1963, "Cheve", "Corvette", "GRRRR", "HONK", true );
            Console.WriteLine($"Car # {CarLot.numberOfCars} was just created.");
            parkAndFly.CarList.Add(car1Type3);


            //*************BONUS X 2*************//
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            var i = 0;
            Console.WriteLine("These are the cars in the car lot");
            foreach(Car tempCar in parkAndFly.CarList)
            {

                Console.WriteLine($"Car {++i} is a {tempCar.Year} {tempCar.Make} {tempCar.Model}");
            }
            
        }
    }
}
