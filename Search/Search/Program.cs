namespace Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            while (true)
            {
                Console.WriteLine("Please enter name: ");
                string entereName = Console.ReadLine();

                if(entereName.ToLower() == "x")
                {
                    break;
                } else
                {
                    names.Add(entereName);
                }
                continue;
            }

            Console.WriteLine("Please type the text: ");
            string text = Console.ReadLine();

            string[] splittedText = text.ToLower().Split(',', ' ', '?', '!', '.', ';');
            counter(names, splittedText);
        }

        public static void counter (List<string> names, string[] text)
        {
            //int counter = 0;

            foreach (string name in names)
            {

                int counter = text.Count(x => x == name);
                //for(int i = 0; i < text.Length; i++)
                //{
                //    if (name == text[i])
                //    {
                //        counter++;
                //    }
                //}
                Console.Write($"{name}: {counter}\n");
                //counter = 0;
            }
        }

    }
}