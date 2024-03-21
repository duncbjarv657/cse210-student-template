using System;

class SimpleGoal : Goal
{
    private bool IsCompleted { get; set; }
    public SimpleGoal(string name, int points) : base(name, points)
    {
        IsCompleted = false;
    }
    public override int CompletedGoal()
    {
        IsCompleted = true;

        return Points;
    }
}