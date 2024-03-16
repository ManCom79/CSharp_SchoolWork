namespace Exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task: Print after dot!!!
            string message = "The whole group G3 loves C#. They find learning this language fun and easy.";

            //First Way
            int indexOfDot = message.IndexOf('.');
            if (indexOfDot == -1)
            {
                Console.WriteLine("Dot was not found");
            } else
            {
                string substring = message.Substring(indexOfDot + 1);
                Console.WriteLine(substring);
            }

            //Second Way
            string[] substrings = message.Split('.');

            if (substrings.Length > 1)
            {
                Console.WriteLine(substrings[1]);
            } else
            {
                Console.WriteLine("Dot was not found");
            }


        }


    }
}