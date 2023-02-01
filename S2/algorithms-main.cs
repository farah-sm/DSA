namespace Week2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 2, 5, 4, 10, 11 };

            Console.WriteLine("Unsorted Array");

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            Agorithms.Agorithms.bubbleSort(array, 3);

            Console.WriteLine("Sorted Array");

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }



        }
    }
}
