using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());


            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    } 
}
        //Console.WriteLine("Hello Prep3 World!"); 
       // int count = 0;
        //while (count < 5)
        //{
        //    System.Console.WriteLine($"count = {count}");
            // count += 1;
            //++count;
          //  ++count;
        //}

        // do-while loop
        //int moreCount = 0;
        //do{
        //    System.Console.WriteLine($"moreCount = {moreCount++}");
        //} while (moreCount < 5);

        // for loop
        //for(var i = 10; i<5; --i)
        //{
          //  System.Console.WriteLine($"i = {i}");
        //}
        //System.Console.WriteLine($"i = {i}");

       // int random = 4;

        //int guess;
        //do
        //{
        //    System.Console.Write("Guess a number (between 1-10):");
        //    guess = int.Parse(Console.ReadLine());

        //    if(guess < 1 || guess > 10) 
        //    {
        //        break;
        //    }

          //  else if(guess < random)
           // {
            //System.Console.WriteLine("Too Low");
            //}

            //else
            //{
            //System.Console.WriteLine("Correct");
            //}
            //} while (random != guess);
        //}
    
//}

