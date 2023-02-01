using System;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SelectSort
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

    }
}
