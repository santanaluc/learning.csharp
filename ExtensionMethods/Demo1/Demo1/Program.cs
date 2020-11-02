namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 11, 2, 8, 10, 45);

            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
