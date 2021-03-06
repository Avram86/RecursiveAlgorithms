using System;

namespace RecursiveAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayFunctions arr = new ArrayFunctions(new int[] { 9,7,2,5,8,1,3,6,10 });

            Console.WriteLine($"The minimum number of the array is: {arr.MinValueOfArray()}");
            Console.WriteLine();

            Console.WriteLine($"The maximum number of the array is: {arr.MaxValueOfArray()}");
            Console.WriteLine();


            arr.AscendingSortingOfTheGivenArray();
            Console.WriteLine();

            bool isCorrectFormat;
            do
            {
                isCorrectFormat = true;
                Console.Write("Please enter a number:");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    int position = arr.IndexOfAnElemetInTheArray(number);

                    Console.WriteLine();
                    Console.WriteLine($"The position of the element {number} is: {position}");
                    Console.WriteLine();

                    arr.FibonacciSequence(number);
                    Console.WriteLine();

                    arr.Factorial(number);
                    Console.WriteLine();
                }
                else
                {
                    isCorrectFormat = false;
                    Console.WriteLine("You did not insert a number!");
                }

            }while(isCorrectFormat==false);
        }
    }
}
