using System;

namespace Counting_Valleys
{
    class Program
    {
        static void Main(string[] args)
        {
            int ActualH= 0;
            int Valleys = 0;
            bool SameValley = false;
            int steps = 0;
            String path;
                Console.WriteLine("Input number of steps");
                steps = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input step sequnece");
                path = Console.ReadLine();

            foreach (char c in path)
            {
                if (c == 'U')
                    ActualH++;
                else
                    ActualH--;
                if (ActualH < 0 & SameValley == false)
                {
                    Valleys++;
                    SameValley = true;
                }
                else if (ActualH >= 0 & SameValley == true)
                {
                    SameValley = false;
                }
            }
            Console.WriteLine(Valleys);
        }
    }

}
