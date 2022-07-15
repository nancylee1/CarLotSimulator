using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car - Done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var carLotList = new CarLot();
             


            var car1 = new Car()   // 1st way is called "Object Initializing Syntax"
            {
                Year = 2022,
                Make = "Hyundai",
                Model = "Genesis",
                EngineNoise = "Grrr",
                HonkNoise = "Toot Toot",
                IsDriveable = true,
            };
           

            var car2 = new Car();  // 2nd way 
            car2.Year = 1996;
            car2.Make = "Mercedes";
            car2.Model = "C-Class";
            car2.EngineNoise = "Brroooooom";
            car2.HonkNoise = "Bark Bark";
            car2.IsDriveable = false;


            var car3 = new Car(2023, "BMW", "5-Series", "Vrooom", "Beep Beep", true); // 3rd way is called "Parameterized Constructor"
            

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            carLotList.ParkingLot.Add(car1);
            carLotList.ParkingLot.Add(car2);
            carLotList.ParkingLot.Add(car3);

            foreach (var car in carLotList.ParkingLot)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
                Console.WriteLine("________________\n");
            }
            Console.WriteLine(CarLot.numberOfCars++);
        }
    }
}
