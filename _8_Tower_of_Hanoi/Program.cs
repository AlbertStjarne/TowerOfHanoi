using System;

namespace _8_Tower_of_Hanoi
{
    class MainClass
    {
        public static void Main(string[] args)
        {

        }

        static void Tower(int n, int sourcePeg, int destinationPeg, int sparePeg)
        {
            if (n == 1)
            {
                Console.WriteLine(sourcePeg + "->" + destinationPeg);
            }
            else
            {
                Tower(n-1)
            }
        }

    }

}