namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.ReadLine());
            int number =  int.Parse(Console.ReadLine());
            if (number < 5)
            {
                Console.WriteLine("number on [he kuni viie vahel");
            }
            else
            {
                Console.WriteLine("number on viiest suurem");
            }
        }
    }
}
