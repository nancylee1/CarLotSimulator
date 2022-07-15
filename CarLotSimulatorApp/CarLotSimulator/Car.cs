using System;
using System.Collections.Generic;
using System.Text;

//TODO

//Create a seperate class file called Car - Done
//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable 
//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() - done
//The methods should take one string parameter: the respective noise property


//Now that the Car class is created we can instanciate 3 new cars
//Set the properties for each of the cars
//Call each of the methods for each car

namespace CarLotSimulator
{
    internal class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }


        public Car(int carYear, string carMake, string carModel, string carEngineNoise, string carHonkNoise, bool carIsDriveable) // constructor
        {
            Year = carYear;
            Make = carMake;
            Model = carModel;
            EngineNoise = carEngineNoise;   
            HonkNoise = carHonkNoise;   
            IsDriveable = carIsDriveable;
            CarLot.numberOfCars++;
        }
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable 
        public int Year { get; set; }
        public string Make { get; set; }    
        public string Model { get; set; }   
        public string EngineNoise { get; set; } 
        public string HonkNoise { get; set; }   
        public bool IsDriveable { get; set; }


        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() 
        //The methods should take one string parameter: the respective noise property

        public void MakeEngineNoise(string Engine)
        {
            Console.WriteLine($"{Engine}");
        }

        public void MakeHonkNoise(string Honk)
        {
            Console.WriteLine($"{Honk}");
        }

    }
}
