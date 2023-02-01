using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            // This Method takes an array as a positional parameter
            void MainMeth(int[] arr, int num)
            {
                int number = num;
                int[] array = arr;

                int start = 0;
                int end = (array.Length - 1);
                bool flag = false;

                while (start <= end)
                {


                    int middle = (start + end) / 2;

                    if (number == array[middle])
                    {
                        Console.WriteLine("Element found: " + array[middle]);
                        flag = true;
                        break;
                    }
                    else if (number < array[middle])
                    {
                        end = middle - 1;
                    }
                    else if (array[middle] < number)
                    {
                        start = middle + 1;
                    }

                }

                if (!flag)
                {
                    Console.WriteLine("Value not found");
                }

            }

            MainMeth(array, 5);



        }
    }
}
