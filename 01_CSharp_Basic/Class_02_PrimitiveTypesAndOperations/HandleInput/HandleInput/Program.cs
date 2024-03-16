namespace HandleInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();

            //Console.WriteLine($"Vnesovte {input}.");

            Console.WriteLine("Enter another number: ");
            string input2 = Console.ReadLine();

            int number1 = int.Parse(input);
            int number2 = int.Parse(input2);
        }
    }
}