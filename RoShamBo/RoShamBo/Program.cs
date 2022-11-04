using System.Net.Security;

class Program
{

    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        string player;
        string Bot;

        while (playAgain)
        {
            Console.WriteLine("Hello welcome to the Ro Sham Bo match. Please say | yes | if you would like to participate.");
            player = Console.ReadLine();
            Bot = ""; 
            if (player == "yes")
            {
                Console.WriteLine("Enter Ro, Sham, or Bo");
                player = Console.ReadLine();
            }
            int BotChoice = random.Next(1,4);
            if (BotChoice == 1)
            {
                Bot = "Ro";
            }

            else if (BotChoice == 2)
            {
                Bot = "Sham";
            }

            else if (BotChoice == 3)
            {
                Bot = "Bo";
            }
            
            if (Bot == "Ro" && player == "Bo")
            {
                Console.WriteLine("You picked Bo and the Bot picked Ro. You lose.");
                Environment.Exit(0);
            }

            if (Bot == "Ro" && player == "Sham")
            {
                Console.WriteLine("You picked Sham and the Bot picked Ro. You win.");
                Environment.Exit(0);
            }

            if (Bot == "Ro" && player == "Ro")
            {
                Console.WriteLine("You picked Ro and the Bot picked Ro. You Tie.");
                Environment.Exit(0);
            }

            if (Bot == "Bo" && player == "Ro")
            {
                Console.WriteLine("You picked Ro and the Bot picked Bo. You win.");
                Environment.Exit(0);
            }

            if (Bot == "Bo" && player == "Sham")
            {
                Console.WriteLine("You picked Sham and the Bot picked Bo. You lose.");
                Environment.Exit(0);
            }

            if (Bot == "Bo" && player == "Bo")
            {
                Console.WriteLine("You picked Bo and the Bot picked Bo. You Tie.");
                Environment.Exit(0);
            }

            if (Bot == "Sham" && player == "Ro")
            {
                Console.WriteLine("You picked Ro and the Bot picked Sham. You lose.");
                Environment.Exit(0);
            }

            if (Bot == "Sham" && player == "Bo")
            {
                Console.WriteLine("You picked Bo and the Bot picked Sham. You win.");
                Environment.Exit(0);
            }

            if (Bot == "Sham" && player == "Sham")
            {
                Console.WriteLine("You picked Sham and the Bot picked Sham. You Tie.");
                Environment.Exit(0);
            }



        }
        Console.ReadKey();
    }
}
