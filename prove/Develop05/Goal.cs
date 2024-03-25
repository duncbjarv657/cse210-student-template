using System;

abstract class Goal
{
    private string Name { get; set; }
    protected int Points { get; set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
    }     

    public void DisplayGoal()

    {
        Console.WriteLine($"Name: {Name} | Points: {Points}");
    }

    public FileGoal(string name, int points)
    {
        

        // varGoal = ({})
    }

    public abstract int CompletedGoal();

    public bool IsCompleted { get; set;}
}
