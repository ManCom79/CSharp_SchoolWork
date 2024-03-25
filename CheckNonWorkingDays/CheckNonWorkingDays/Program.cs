namespace CheckNonWorkingDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                List<DateTime> nonWorkingDays = new List<DateTime>()
                {
                    new DateTime(2024, 1, 1),
                    new DateTime(2024, 1, 7),
                    new DateTime(2024, 1, 7),
                    new DateTime(2024, 1, 7),
                    new DateTime(2024, 1, 7),
                    new DateTime(2024, 1, 7),
                    new DateTime(2024, 1, 7)
                };

                Console.WriteLine("Please enter day (integer):");
                string day = Console.ReadLine();

                if (!int.TryParse(day, out int intDay))
                {
                    Console.WriteLine("Please use integres only.");
                    continue;
                }

                Console.WriteLine("Please enter month (integer):");
                string month = Console.ReadLine();

                if (!int.TryParse(month, out int intMonth))
                {
                    Console.WriteLine("Please use integres only.");
                    continue;
                }

                Console.WriteLine("Please enter year (integer):");
                string year = Console.ReadLine();

                if (!int.TryParse(year, out int intYear))
                {
                    Console.WriteLine("Please use integres only.");
                    continue;
                }

                try
                {
                    DateTime date = new DateTime(intYear, intMonth, intDay);
                    Console.WriteLine(date);
                } catch
                {
                    Console.WriteLine("Please enter a valid date!");
                }

                

            }
        }
    }
}