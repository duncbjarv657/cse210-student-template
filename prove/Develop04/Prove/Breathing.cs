 public class DoBreathingActivity
    {
        public static void Breathe()
        {
            Console.WriteLine("Breathing activity:");
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

            Console.Write("Enter duration (in seconds): ");
            int duration = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Starting the breathing activity...");

            for (int i = 0; i < duration; i++)
            {
                Console.WriteLine((i % 2 == 0) ? "Breathe in..." : "Breathe out...");
                Console.Write((duration - i) + " ");
            }

            Console.WriteLine("\nBreathing activity complete.");
        }
    }