using System;

//Create a seperate class file called Car
public class Car
{
    public Car()
    {

    }
    //Create a seperate class file called Car
    //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
    {
        Year = year;
        Make = make;
        Model = model;
        EngineNoise = engineNoise;
        HonkNoise = honkNoise;
        IsDriveable = isDriveable;

    }
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    public void MakeEngineNoise(string engineNoise)
    {
        Console.WriteLine(engineNoise);
    }
    public void MakeHonkNoise( string honkNoise)
    {
        Console.WriteLine(honkNoise);
    }
    /*Car car1 = new Car(1965, "Shelby", "Mustang", "Vroom", "BeepBeep", true)
    {

    };
    Car car2 = new Car(1998, "Honda", "Accord", "Purrrr", "WompWomp", false)
    {

    };
    Car car3 = new Car(2023, "Chevy", "Corvette", "Whirrrrr", "MEEEEEEEEEP", true)
    {

    };*/
    

}

