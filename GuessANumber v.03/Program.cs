
// добавена опция за нова игра



Random randomNumber = new Random();
Console.Write($"Hello, the game is simple. I randomly picked a number between 1 - 100," +
    $"\nyou have 3 tries to find out which number I've picked." +
    $"\nIf you failed to find out the number, you can choose between Yes or No to play again." +
    $"\nGood luck! ");
int computerNumber = randomNumber.Next(1, 101);
bool isMatch = false;
int wrongTries = 0;


while (isMatch == false)
{
    Console.WriteLine();
    Console.WriteLine($"Choose any number between 1 - 100: ");
    int playerNumber = int.Parse(Console.ReadLine());
    Console.WriteLine($"{playerNumber}");
    if (playerNumber < 1 || playerNumber > 100)
    {
        Console.WriteLine("Invalid input!");
        continue;
    }
    if (playerNumber == computerNumber)
    {
        isMatch = true;
        Console.WriteLine("BINGO!\nYou've guest it!");
        Console.WriteLine("Do you want to play again?");
        string answear = Console.ReadLine();
        switch (answear)
        {
            case "Yes":
                wrongTries = 0;
                isMatch = false;
                break;
            case "No":
                Console.WriteLine("Thanks for playing!\nBye bye!");
                return;
        }

    }
    else if (playerNumber > computerNumber)
    {
        Console.WriteLine("Too high");
        wrongTries++;
        if (wrongTries == 10)
        {
            Console.WriteLine("Game over");
            Console.WriteLine("Do you want to play again?");
            string answear = Console.ReadLine();
            switch (answear)
            {
                case "Yes":
                    wrongTries = 0;
                    break;
                case "No":
                    Console.WriteLine("Thanks for playing!\nBye bye!");
                    return;
            }
        }
    }
    else
    {
        Console.WriteLine("Too low");
        wrongTries++;
        if (wrongTries == 10)
        {
            Console.WriteLine("Game over");
            Console.WriteLine("Do you want to play again?");
            string answear = Console.ReadLine();
            switch (answear)
            {
                case "Yes":
                    wrongTries = 0;
                    break;
                case "No":
                    Console.WriteLine("Thanks for playing!\nBye bye!");
                    return;
            }
        }
    }
}
