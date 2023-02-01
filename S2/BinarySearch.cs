using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            int number = 1;

            int[] array = { 1, 2, 4, 12, 14, 18, 19, 20 };

            // Console.WriteLine(array[0]);

            int start = 0;
            int end = (array.Length - 1) ;
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
