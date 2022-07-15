using System;
using System.Collections.Generic;
using System.Text;

//*************BONUS X 2*************//
//Create a CarLot class
//It should have at least one property: a List of cars
//Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
//At the end iterate through the list printing each of car's Year, Make, and Model to the console

namespace CarLotSimulator
{
    internal class CarLot
    {
        public CarLot()
        {

        }

        public List<Car> ParkingLot = new List<Car>();


        public static int numberOfCars;
      
    }
}

//Exercise 2:
//Building on our car lot simulator project, create a CarLot class with a static field called numberOfCars.
//Have this number only increment when in our program we create a new Car.
//From there create 3 cars in the Main() and then each time you create a car, do a Console.WriteLine() printing the current number of cars in the car lot.