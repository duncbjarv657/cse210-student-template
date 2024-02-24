using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        int count = 23;

        var cars = new List<Car>();

        var car = new Car();
        car.make = "Honda";
        car.model = "Civic";
        car.year = 2024;
        car.gallons = 10;
        car.milesPerGallon = 30;

        var owner = new Person();
        owner.name = "bob";
        owner.phone = "333-3333";
        car.owner = owner;

        cars.Add(car);

        car = new Car();
        car.make = "Ford";
        car.model = "F-150";
        car.year = 2021;
        car.gallons = 30;
        car.milesPerGallon = 5;

        owner = new Person();
        owner.name = "sue";
        owner.phone = "444-4444";
        car.owner = owner;


        cars.Add(car);

        Console.Clear();
        foreach (var c in cars)
        {
            //System.Console.WriteLine($"{c.make} {c.model}: totalRange = {c.TotalRange()}");
            c.Display();
        }
        //var makes = new List<string>();
        //var models = new List<string>();

        //var make1 = "Honda";
        //var model1 = "Civic";

        //var make2 = "Ford";
        //var model2 = "F-150";

    }
}


 //class Car
//  {
//     public string model;
//     public string make;
//     public int year = 2021;
//     public int milesPerGallon;
//     public int gallons;
//     public Person owner;

//     public int TotalRange() {
//         return gallons * milesPerGallon;
//     }

//     public void Display() {
//         System.Console.WriteLine($"{make} {model} {year} {owner.DisplayString()}: totalRange = {TotalRange()}");
//     }
//  }