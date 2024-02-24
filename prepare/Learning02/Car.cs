class Car
{
    public string model;
    public string make;
    public int year = 2021;
    public int milesPerGallon;
    public int gallons;
    public 

    public int TotalRange() {
        return gallons * milesPerGallon;
    }

    public void Display() {
        System.Console.WriteLine($"{make} {model} {year} {owner.DisplayString()}: totalRange = {TotalRange()}");
    }
 }

    class Person{
        public string name;
        public string phone;
        public void Display() {
            return $"{name} {phone}";
        }
    }