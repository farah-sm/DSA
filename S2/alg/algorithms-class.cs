using System;
using System.Text;
using System.Threading.Tasks;

namespace Agorithms
{
    internal class Agorithms
    {

        // int[] array = { 3, 2, 5, 4, 10, 11 };
        public static void selectSort(int[] arr)
        {
            int[] array = arr;
            int lastUnsorted = array.Length - 1;

            while (lastUnsorted > 0)
            {
                int maxInd = 0;
                int maxVal = array[0];

                for (int i = 0; i <= lastUnsorted; i++)
                {
                    if (array[i] > maxVal)
                    {
                        maxVal = array[i];
                        maxInd = i;
                    }
                }
                array[maxInd] = array[lastUnsorted];
                array[lastUnsorted] = maxVal;
                lastUnsorted--;
            }
        }

        public static void bubbleSort(int[] arr, int num)
        {
            int[] array = arr;
            int number = num;

            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
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

        public void binarySearch(int[] arr, int num)
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



    }
}
