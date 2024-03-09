 public class DoListingActivity
    {
        public static void Start()
        {
            Console.WriteLine("Listing activity:");
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

            Console.Write("Enter duration (in seconds): ");
            int duration = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Starting the listing activity...");
            Random rand = new Random();
            string[] prompts = new string[]
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };

            int count = 0;
            Console.WriteLine("Prompt: " + prompts[rand.Next(prompts.Length)]);

            for (int i = 0; i < duration; i++)
            {
                Console.Write("Enter item: ");
                string item = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(item))
                    break;
                count++;
                Console.Write((duration - i) + " ");
            }

            Console.WriteLine($"\nYou listed {count} items.");
            Console.WriteLine("Listing activity complete.");
        }
    }