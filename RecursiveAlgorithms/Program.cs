﻿using System;

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
        }
            
    }

    
    
}