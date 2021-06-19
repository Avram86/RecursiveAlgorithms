using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveAlgorithms
{
    public class ArrayFunctions
    {
        private readonly int[] _array;
        private int min;
        private int max;
        private int position;

        public ArrayFunctions(int[] array)
        {
            _array = array;
            min = array[0];
            max = array[0];
        }
        public int MinValueOfArray()
        {
            return MinValue(0);
        }

        private int MinValue(int i)
        {
            if (i >= 0 && i < _array.Length)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                    //Console.WriteLine($"At step {i} min={min}");
                }

                MinValue(i + 1);
            }

            return min;
        }

        public int MaxValueOfArray()
        {
            return MaxValue(0);
        }

        private int MaxValue(int i)
        {
            if (i >= 0 && i < _array.Length)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                    //Console.WriteLine($"At step {i} max={max}");
                }

                MaxValue(i + 1);
            }

            return max;
        }

        public void AscendingSortingOfTheGivenArray()
        {
            int intermediary = 0;
            bool isSorted;

            do
            {
                isSorted = true;

                for (int i = 0; i < _array.Length - 1; i++)
                {
                    if (_array[i] > _array[i + 1])
                    {
                        intermediary = _array[i];
                        _array[i] = _array[i + 1];
                        _array[i + 1] = intermediary;

                        isSorted = false;

                        break;
                    }
                }
            } while (!isSorted);

            PrintAnArray(_array);
        }

        public void PrintAnArray(int[] array)
        {
            Console.Write("The array is: ");

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write($"{array[i]}");
                }
                else
                {
                    Console.Write($"{array[i]}, ");
                }
            }

            Console.WriteLine();
        }

        public int IndexOfAnElemetInTheArray(int element)
        {
            return IndexOfAnElement(0, element);
        }

        private int IndexOfAnElement(int index, int element)
        {

            if(index>=0 && index < _array.Length)
            {
                if (_array[index] == element)
                {
                    position = index;
                    return position;
                }

                IndexOfAnElement(index + 1, element);
            }
            else
            {
                position = int.MinValue;
                //throw new ArgumentNullException("The chosen value was not in the arary!");
            }

            return position;
        }

        public void FibonacciSequence(int number)
        {
            Console.Write($"Fibonacci sequence of {number}:");

            int[] result = new int[number+1];

            for(int i = 0;i<=number;i++)
            {
                result[i] = Fibonacci(i);
                
                Console.Write($"{result[i]}, ");
            }

            Console.WriteLine();
        }

        private int Fibonacci(int number)
        {

            if (number == 0)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(number - 1) + Fibonacci(number - 2);
            }            
        }

        public void Factorial(int number)
        {
            Console.Write($"Factorial de {number}: ");

            int[] result = new int[number + 1];

            for(int i = 0; i <= number; i++)
            {
                result[i] = FactorialOfNumber(i);
                if (i != number)
                {
                    Console.Write($"{FactorialOfNumber(i)}, ");
                }
                else
                {
                    Console.Write($"{FactorialOfNumber(i)}");
                }
            }
        }

        private int FactorialOfNumber(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * FactorialOfNumber(number - 1);
            }
        }

    }
}
