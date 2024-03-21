using System;

class Program
{
    static void Main(string[] args)
    {
    
        List <Goal> goals = new List<Goal>();
        int totalPoints = 0;
        while (true){
        System.Console.WriteLine("Welcome to Goal Tracker! What goals do you want to work on?");
        Console.WriteLine("1. Create A New Goal");
        Console.WriteLine("2. List goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record event");
        Console.WriteLine("6. Quit");
        Console.Write("Enter your choice human: ");

        string choice = Console.ReadLine();
        Console.WriteLine();

         switch (choice)
        {
            case "1":
                goals.Add(CreateGoal());
                break;
            case "2":
                ListGoals(goals);
                break;
            case "3":
                goals.Add(SaveGoals());
                 break;
            // case "4":
            //     goals.Add(LoadGoals());
            //     break;
            case "5":
                totalPoints += RecordEvent(goals);
                break;
            case "6":
                Console.WriteLine("Goodbye!");
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
            }
        }
    }


    static Goal CreateGoal()
    {
        Console.WriteLine(" Do you want a, 1. Simple Goal, 2. Eternal Goal, 3. Checklist Goal, pick(1-3): ");
        string choice = Console.ReadLine();

        Console.WriteLine("What is the name of your goal?: ");
        string name = Console.ReadLine();

        Console.WriteLine("How many points is this goal worth?: ");
        int points = int.Parse(Console.ReadLine());

        
        switch (choice)
        {
            case "2":
                return new EternalGoal(name, points);
            case "3":
                //prompt for more for completion and bonus points
                return new ChecklistGoal(name, points);
            default:
                 return new SimpleGoal(name, points);
        }

    }
    static void ListGoals(List<Goal> goals)
       {
        Console.WriteLine("List of Goals:");
        foreach (var goal in goals)
        {
            goal.DisplayGoal();
        }
        }

   static void SaveGoals(List<Goal> goals)
   {
      Console.WriteLine("Enter the file name to save the goals to:");
       int fileName = int.Parse(Console.ReadLine());

        try
      {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Goal goal in goals)
             {
                 writer.WriteLine($"{goal.Name},{goal.Points},{goal.IsCompleted},{goal.Type}");
              }
          }

            Console.WriteLine($"Goals have been saved to {fileName}.");
        }
        catch (Exception ex)
        {            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalPoints = 0;
        while (true)
        {
            Console.WriteLine("Welcome to Goal Tracker! What goals do you want to work on?");
            Console.WriteLine("1. Create A New Goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("Enter your choice human: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    goals.Add(CreateGoal());
                    break;
                case "2":
                    ListGoals(goals);
                    break;
                case "3":
                    SaveGoals(goals);
                    break;
                case "4":
                    goals.AddRange(LoadGoals());
                    break;
                case "5":
                    totalPoints += RecordEvent(goals);
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Other methods here...

    static List<Goal> LoadGoals()
    {
        List<Goal> loadedGoals = new List<Goal>();
        
        Console.WriteLine("Enter the file name to load goals from:");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string name = parts[0];
                    int points = int.Parse(parts[1]);
                    bool isCompleted = bool.Parse(parts[2]);
                    string type = parts[3];

                    // Create the appropriate goal based on type
                    Goal goal;
                    switch (type)
                    {
                        case "Simple":
                            goal = new SimpleGoal(name, points);
                            break;
                        case "Eternal":
                            goal = new EternalGoal(name, points);
                            break;
                        case "Checklist":
                            goal = new ChecklistGoal(name, points);
                            break;
                        default:
                            // Handle unknown type
                            continue;
                    }

                    goal.IsCompleted = isCompleted;
                    loadedGoals.Add(goal);
                }
            }

            Console.WriteLine($"Goals have been loaded from {fileName}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }

        return loadedGoals;
    }

    // Other methods here...
}

static int RecordEvent(List<Goal> goals)
    {

        Console.WriteLine("List of Goals:");
        
        for(int i = 0; i<goals.Count;++i)
        {
        Console.Write($"Goal Number {i}: ");
            var mygoal = goals [i];
            mygoal.DisplayGoal();
        }
    //   int points = int.Parse(Console.ReadLine());

        int index = int.Parse(Console.ReadLine());
        var goal = goals [index];
        var points = goal.CompletedGoal();
        return points;
// //         goal.IsCompleted = true;
// //         Console.WriteLine($"Progress for goal '{goal.Name}' worth {goal.Points} points recorded on {date}: {description}");
    }
}