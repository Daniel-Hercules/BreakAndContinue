using System;

namespace BreakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Counter set to count to 10 
            for (int c = 0; c < 10; c++)
            {
                // But will stop when it gets to 5
                if (c == 5) 
                {
                    break;
                }
                Console.WriteLine(c);
            }
            // Counter set to count to 10 
            for (int c = 0; c < 10; c++)
            {
                // But will stop when it gets to 5
                // Continue allows us to continue the parent loop
                if (c == 5)
                {
                    Console.WriteLine("Checkpoint Reached!! Counter is at 5");
                    continue;
                }
                Console.WriteLine("Counter is at " + c);
            }
        }
    }
}
