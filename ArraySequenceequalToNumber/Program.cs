using System;

namespace ArraySequenceequalToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,4,0,1 };

            int number = int.Parse(Console.ReadLine());

            int bestIndex = 0;
            int bestLenght = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currElement = array[i];

                int currSum = currElement;
                int currLen = 0;
                for (int y = i+1; y < array.Length; y++)
                {
                    currSum += array[y];
                    currLen++;
                    if (currSum == number)
                    {
                        bestIndex = i;
                        bestLenght = currLen;
                    }
                }
            }
            Console.WriteLine(bestIndex);
            Console.WriteLine(bestLenght);
        }
    }
}
