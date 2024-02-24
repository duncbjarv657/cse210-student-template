using System;
using System.ComponentModel.Design;

//using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Run();
    }

    static void Run()
    {
        Journal journal = new Journal();

        bool keepGoing = true;

        while (keepGoing)
        {
            int selection = ShowMenu();

            switch (selection)
            {
                case 1:
                    string prompt = Prompt.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    var placeholderResponse = Console.ReadLine();
                    var entry = new Entry(placeholderResponse, prompt, DateTime.Today.ToString());
                    journal.AddEntry(entry);
                    break;

                case 2:
                    // Display entries
                    foreach (Entry e in journal.entry_list)
                    {
                        Console.WriteLine(e); // Assuming Entry class has overridden ToString() method
                    }
                    break;

                case 3:
                    // Load entries from file
                    journal.StringLoad();
                    break;

                case 4:
                    // Save entries to file
                    journal.StringSave();
                    break;

                case 5:
                    Console.WriteLine("Quitting Journal");
                    keepGoing = false;
                    break;

                default:
                    // Handle invalid selection
                    Console.WriteLine("Invalid selection. Please choose again.");
                    break;
            }
        }
    }

    static int ShowMenu()
    {
        Console.WriteLine("Select Option: \n 1. Add Entry \n 2. Display Entries \n 3. Load \n 4. Save \n 5. Quit");
        string input = Console.ReadLine();

        return int.Parse(input);
    }
}


//using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Develop02 World!");
//         Run();
//     }

//     static void Run()
//     {
//         Journal journal = new Journal();

//         bool keepGoing = true;

//         foreach (keepGoing)
//         {
//             int selection = ShowMenu();

//             switch (selection)
//             {
//                 case 1:
//                     string prompt = Prompt.GetRandomPrompt();
//                     Console.WriteLine(prompt);
//                     var placeholderResponse = Console.ReadLine();
//                     var entry = new Entry(placeholderResponse, prompt, DateTime.Today.ToString());
//                     journal.AddEntry(entry);
//                     break;

//                 case 2:
//                     // Display entries
//                     foreach (Entry e in journal.entry_list)
//                     {
//                         Console.WriteLine(e); // Assuming Entry class has overridden ToString() method
//                     }
//                     break;

//                 case 3:
//                     // Load entries from file
//                     journal.StringLoad();
//                     break;

//                 case 4:
//                     // Save entries to file
//                     journal.StringSave();
//                     break;

//                 case 5:
//                     Console.WriteLine("Quitting Journal");
//                     keepGoing = false;
//                     break;

//                 case 6:
//                     // Handle invalid selection
//                     Console.WriteLine("Invalid selection. Please choose again.");
//                     break;
//             }
//         }
//     }

//     static int ShowMenu()
//     {
//         Console.WriteLine("Select Option: \n 1. Add Entry \n 2. Display Entries \n 3. Load \n 4. Save \n 5. Quit");
//         string input = Console.ReadLine();

//         return int.Parse(input);
//     }
// }

// class Program
// {

//     //public Journal journal = new Journal();

//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Develop02 World!");
//         Run();
//     }
//     public string GetPrompt()
//     {
//         return "";
//     }

//     var selection = ShowMenu();

// switch (selection)
// {
//     case 1:
//         string prompt = Prompt.GetRandomPrompt();
//         Console.WriteLine(prompt);
//         var placeholderResponse = Console.ReadLine();
//         var entry = new Entry(placeholderResponse, prompt, DateTime.Today.ToString());
//         journal.AddEntry(entry);
//         break;

//     case 2:
//         // Display entries
//         foreach (Entry e in journal.entry_list)
//         {
//             Console.WriteLine(e); // Assuming Entry class has overridden ToString() method
//         }
//         break;

//     case 3:
//         // Load entries from file
//         journal.StringLoad();
//         break;

//     case 4:
//         // Save entries to file
//         journal.StringSave();
//         break;

//     case 5:
//         Console.WriteLine("Quitting Journal");
//         System.Environment.Exit(1);
//         break;

//     default:
//         // Handle invalid selection
//         Console.WriteLine("Invalid selection. Please choose again.");
//         break;
// }


//     // static public void Run()
//     // {
//     //     bool keepGoing = true;
//     //     Journal journal = new Journal();
//     //     Console.WriteLine()

//     //     switch(keepGoing) 
//     //     {
//     //         var selection = ShowMenu();

//     //         case(selection == 1): 

//     //             string prompt = Prompt.GetRandomPrompt();
//     //             Console.WriteLine(prompt);
//     //             var placeholderResponse = Console.ReadLine();
                
//     //             var entry = new Entry(placeholderResponse, prompt, DateTime.Today.ToString());
                
//     //             journal.AddEntry(entry);

//     //             break;
            
//     //         case (selection == 2):
//     //             //Display entries
                
//     //             foreach (Entry e in journal.entry_list)
//     //             {
//     //                 Console.WriteLine();
//     //             }
//     //             break;
            
//     //         case(selection == 3):
//     //             //var prompt = "How did I see the hand of the Lord in my life today?";
//     //             // Console.WriteLine();
//     //             // var placeholderResponse = Console.ReadLine();

//     //             // var entry = new Entry();
//     //             // journal.AddEntry(entry);
//     //             journal.StringLoad()
//     //             break;
//     //         case (selection == 4):
//     //             //var prompt = "What was the strongest emotion I felt today?";
//     //             //Console.WriteLine();
//     //             //var placeholderResponse = Console.ReadLine();

//     //             //var entry = new Entry();
//     //             //journal.AddEntry(entry);
//     //             journal.StringSave()
//     //             break;
            
//     //         case(selection == 5):
//     //             //var prompt = "If I had one thing I could do over today, what would it be?";
//     //             Console.WriteLine("Quiting Journal");
//     //             // var placeholderResponse = Console.ReadLine();

//     //             // var entry = new Entry();
//     //             // journal.AddEntry(entry);
//     //             System.Environment.Exit(1);
//     //             break;
            
//     //         default:
            
//     //             break;
            
//     //     }

//     static int ShowMenu() 
//     {
//         Console.WriteLine("Select Option: \n 1. Add Entry \n 2. Display Entries \n 3. Load \n 4. Save \n 5. Quit");
//         string input = Console.ReadLine();
            

//         return int.Parse(input);
//     }

   
// }
// }