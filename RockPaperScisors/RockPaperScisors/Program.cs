namespace RockPaperScisors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userWins = 0;
            int computerWins = 0;
            int tieGames = 0;
            string[] itemsToSelect = { "Rock", "Paper", "Scisors"};
            
            while (true) {

                Random rnd = new Random();
                int computerSelectionInteger = rnd.Next(0, 2);
                string computerSelection = itemsToSelect[computerSelectionInteger];

                Console.WriteLine("Please select:\n1. Play Game\n2. Show Stats\n3. Exit");
                string userSelectedAction = Console.ReadLine();

                switch (userSelectedAction)
                {
                    case "1":
                        {
                            Console.WriteLine("Please select:\n1. Rock\n2. Paper\n3. Scisors");
                            string userSelection = Console.ReadLine();
                            switch(userSelection)
                            {
                                case "1":
                                    {
                                        userSelection = "Rock";
                                        string result = calculateWinner(userSelection, computerSelection);
                                        if (result == "won") {
                                            userWins++;
                                        } else if (result == "lost")
                                        {
                                            computerWins++;
                                        }
                                        else if (result == "tie")
                                        {
                                            tieGames++;
                                        }
                                        continue;
                                    }
                                case "2":
                                    {
                                        userSelection = "Paper";
                                        string result = calculateWinner(userSelection, computerSelection);
                                        if (result == "won")
                                        {
                                            userWins++;
                                        }
                                        else if (result == "lost")
                                        {
                                            computerWins++;
                                        }
                                        else if (result == "tie")
                                        {
                                            tieGames++;
                                        }
                                        continue;
                                    }
                                case "3":
                                    {
                                        userSelection = "Scisors";
                                        string result = calculateWinner(userSelection, computerSelection);
                                        if (result == "won")
                                        {
                                            userWins++;
                                        }
                                        else if (result == "lost")
                                        {
                                            computerWins++;
                                        }
                                        else if (result == "tie")
                                        {
                                            tieGames++;
                                        }
                                        continue;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Invalid selection, please try again.");
                                        continue;
                                    }
                            }
                        }
                    case "2":
                        {
                            Console.WriteLine($"User has won {userWins} times. Computer won {computerWins} times. There were {tieGames} tied games.");
                            Console.WriteLine($"Your win {(((double)userWins)/(userWins + computerWins + tieGames))*100} percent of time.");
                            continue;
                        }
                    case "3":
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid selection. Please try again.");
                            continue;
                        }

                }

                break;
            }
            
        }
        static string calculateWinner(string userSelection, string computerSelection)
        {
            string result = "";
            switch(userSelection)
            {
                case "Rock": {
                        if(computerSelection == "Rock")
                        {
                            Console.WriteLine("No winner, it's a tie game. Both selected \"Rock\".");
                            result = "tie";
                        } else if (computerSelection == "Paper")
                        {
                            Console.WriteLine($"You lost! You selected {userSelection}, computer selected {computerSelection}.");
                            result = "lost";
                        }
                        else if (computerSelection == "Scisors")
                        {
                            Console.WriteLine($"You win! You selected {userSelection}, computer selected {computerSelection}.");
                            result = "won";
                        }
                        break;
                    }
                case "Paper":
                    {
                        if (computerSelection == "Rock")
                        {
                            Console.WriteLine($"You win! You selected {userSelection}, computer selected {computerSelection}.");
                            result = "won";
                        }
                        else if (computerSelection == "Paper")
                        {
                            Console.WriteLine("No winner, it's a tie game. Both selected \"Paper\".");
                            result = "tie";
                        }
                        else if (computerSelection == "Scisors")
                        {
                            Console.WriteLine($"You lost! You selected {userSelection}, computer selected {computerSelection}.");
                            result = "lost";
                        }
                        break;
                    }
                case "Scisors":
                    {
                        if (computerSelection == "Rock")
                        {
                            Console.WriteLine($"You lost! You selected {userSelection}, computer selected {computerSelection}.");
                            result = "lost";
                        }
                        else if (computerSelection == "Paper")
                        {
                            Console.WriteLine($"You win! You selected {userSelection}, computer selected {computerSelection}.");
                            result = "won";
                        }
                        else if (computerSelection == "Scisors")
                        {
                            Console.WriteLine("No winner, it's a tie game. Both selected \"Paper\".");
                            result = "tie";
                        }
                        break;
                    }
            }
            return result;
        }
    }
}
