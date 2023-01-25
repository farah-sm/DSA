namespace DataStructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TubeStation testing = new TubeStation(35, "Whitechapel", "DLR", "Stairs", 2, "Open");

            Console.WriteLine($"{testing.ToString()}");
        }
    }
}
