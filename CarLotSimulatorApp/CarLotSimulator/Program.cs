﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            Car car1 = new Car(1965, "Shelby", "Mustang", "Vroom", "BeepBeep", true)
            {
                
            };
            Car car2 = new Car(1998, "Honda", "Accord", "Purrrr", "WompWomp", false)
            {

            };
            Car car3 = new Car(2023, "Chevy", "Corvette", "Whirrrrr", "MEEEEEEEEEP", true)
            {
                
            };
            Console.WriteLine("Car 1");
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);
            Console.WriteLine("Car 2");
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            Console.WriteLine("Car 3");
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

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
