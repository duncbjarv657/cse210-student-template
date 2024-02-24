using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> verses = new List<string>
            {
                "John 3:16",
                "For God so loved the world, that he gave his only begotten son,",
                "that whosoever believeth in him should not perish, but have eternal life."
            };

            Scripture scrip = new Scripture("ref", verses);
            Random randomGenerator = new Random();
            scrip.HideWords(3);
            scrip.Display();

            int number = randomGenerator.Next(1, 99);
            scrip.IsAllHidden();
            scrip.Clear();
    } 
}