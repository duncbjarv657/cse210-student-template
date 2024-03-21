// using System;

// class ChecklistGoal : Goal
// {
//     public ChecklistGoal(string name, int points) : base(name, points)
//     {
//     }
//     public override int CompletedGoal()
//     {

//     }
// }

using System;
using System.Collections.Generic;

class ChecklistGoal : Goal
{
    private List<string> checklist;

    public ChecklistGoal(string name, int points) : base(name, points)
    {
        checklist = new List<string>();
    }

    // Method to add a task to the checklist
    public void AddTask(string goal)
    {
        checklist.Add(goal);
    }

    // Method to mark a task as completed
    public void MarkTaskCompleted(string goal)
    {
        if (checklist.Contains(goal))
        {
            checklist.Remove(goal);
        }
    }

    // Override the CompletedGoal method to check if all tasks are completed
    public override int CompletedGoal()
    {
        return Points;
    }
}

