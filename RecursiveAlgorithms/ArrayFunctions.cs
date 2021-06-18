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

            Console.Write("The array is: ");

            for (int i = 0; i < _array.Length; i++)
            {
                if (i == _array.Length - 1)
                {
                    Console.Write($"{_array[i]}");
                }
                else
                {
                    Console.Write($"{_array[i]}, ");
                }
            }
        }

    }
}
