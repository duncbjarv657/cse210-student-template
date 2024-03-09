 public class DoReflectionActivity
    {
        private static List<string> prompts;
        private static List<string> questions;
        private static int durationInSeconds;

        public static void Reflect()
        {
            Console.WriteLine("Welcome to the Reflect on Strength activity!");
            Console.Write("Enter duration (in seconds): ");
            durationInSeconds = Convert.ToInt32(Console.ReadLine());

            // Prompts and Questions
            InitializePrompts();
            InitializeQuestions();

            // Show the standard starting message
            ShowStartingMessage();

            // Randomly select a prompt and display it
            Random rand = new Random();
            string randomPrompt = prompts[rand.Next(prompts.Count)];
            Console.WriteLine(randomPrompt);

            // Show the standard finishing message
            ShowFinishingMessage();
        }

        private static void InitializePrompts()
        {
            // Initialize prompts
            prompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };
        }

        private static void InitializeQuestions()
        {
            // List of Questions asked to the user
            questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
        }

        private static void ShowStartingMessage()
        {
            Console.WriteLine($"This activity will run for {durationInSeconds} seconds.");
            Console.WriteLine("Let's begin...");
        }

        private static void ShowFinishingMessage()
        {
            Console.WriteLine("Thank you for participating in the Reflect on Strength activity!");
        }
    }