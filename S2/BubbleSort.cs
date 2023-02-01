using System;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BubbleSort
    {

        // int[] array = { 3, 2, 5, 4, 10, 11 };
        public static void bubbleSort(int[] arr, int num)
        {
            int[] array = arr;
            int number = num;

            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1 ; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        int temp1 = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp1;

                    }
                    else
                    {
                        // already sorted
                    }
                }
            }

        }

    }
}
