
// добавена опция за нова игра


Random randomNumber = new Random();
Console.WriteLine("INSERT YOUR NAME");
string playerName = Console.ReadLine();
int wrongTries = 7;
Console.Write($"Hello {playerName}, the game is simple. I randomly picked a number between 1 - 100," +
    $"\nyou have {wrongTries} tries to find out which number I've picked." +
    $"\nIf you failed to find out the number, you can choose between Yes or No to play again." +
    $"\nGood luck! ");
int computerNumber = randomNumber.Next(1, 101);
bool isMatch = false;
bool playAgain = false;

while (playAgain == false)
{
    while (isMatch == false)
    {
        //wrongTries = 7;
        Console.WriteLine();
        Console.WriteLine($"Choose any number between 1 - 100: ");
        int playerNumber = int.Parse(Console.ReadLine());
        Console.WriteLine($"{playerNumber}");
        if (playerNumber < 1 || playerNumber > 100)
        {
            Console.WriteLine("Invalid input! You must choose between 1 - 100");
            continue;
        }
        if (playerNumber == computerNumber)
        {
            Console.WriteLine("BINGO!\nYou've guest it!");
            Console.WriteLine("Do you want to play again? Type: Yes/No?");
            string answear = Console.ReadLine();
            switch (answear)
            {
                case "Yes":
                    wrongTries = 7;
                    Console.WriteLine("Do you want to make it bit harded and go to leve 2? Type: Yes/No?");
                    string leve2Answear = Console.ReadLine();
                    if (leve2Answear == "Yes")
                    {
                        isMatch = true;
                        break;
                    }
                    else
                    {
                        computerNumber = randomNumber.Next(1, 101);
                        break;
                    }
                case "No":
                    Console.WriteLine("Thanks for playing!\nBye bye!");
                    playAgain = true;
                    return;
                default:
                    Console.WriteLine("Invalid input"); 
                    break;
            }
        }
        else if (playerNumber > computerNumber)
        {
            Console.WriteLine("Too high");
            wrongTries--;
            Console.WriteLine($"You got: {wrongTries} tries left");
            if (wrongTries == 0)
            {
                Console.WriteLine("Game over");
                Console.WriteLine("Do you want to play again? Type: Yes/No?");
                string answear = Console.ReadLine();
                switch (answear)
                {
                    case "Yes":
                        wrongTries = 0;
                        Console.WriteLine("Do you want to make it bit harded and go to leve 2? Type: Yes/No?");
                        string leve2Answear = Console.ReadLine();
                        if (leve2Answear == "Yes")
                        {
                            break;
                        }
                        else
                        {
                            computerNumber = randomNumber.Next(1, 101);
                            break;
                        }
                    case "No":
                        Console.WriteLine("Thanks for playing!\nBye bye!");
                        playAgain = true;
                        return;
                }
                break;
            }
        }
        else
        {
            Console.WriteLine("Too low");
            wrongTries--;
            Console.WriteLine($"You got: {wrongTries} tries left");
            if (wrongTries == 0)
            {
                Console.WriteLine("Game over");
                Console.WriteLine("Do you want to play again? Type: Yes/No?");
                string answear = Console.ReadLine();
                switch (answear)
                {
                    case "Yes":
                        wrongTries = 7;
                        Console.WriteLine("Do you want to make it bit harded and go to leve 2? Type: Yes/No?");
                        string leve2Answear = Console.ReadLine();
                        if (leve2Answear == "Yes")
                        {
                            break;
                        }
                        else
                        {
                            computerNumber = randomNumber.Next(1, 101);
                            break;
                        }
                    case "No":
                        Console.WriteLine("Thanks for playing!\nBye bye!");
                        playAgain = true;
                        return;
                }
            }
        }
    }

    // започва ниво 2 
    int wrongTriestLevel2 = 5;
    Console.WriteLine($"Now level 2 begins!\n" +
        $"The rules are the same but now you've to guess between 1-200 and now ypu have only {wrongTriestLevel2} tries to find it out");
    int computerNumberLecvel2 = randomNumber.Next(1, 201);
    bool isMatchLevel2 = false;
    while (isMatchLevel2 == false)
    {
        Console.WriteLine();
        Console.WriteLine($"Choose any number between 1 - 200: ");
        int playerNumber = int.Parse(Console.ReadLine());
        Console.WriteLine($"{playerNumber}");
        if (playerNumber < 1 || playerNumber > 200)
        {
            Console.WriteLine("Invalid input! You must choose between 1 - 200");
            continue;
        }
        if (playerNumber == computerNumberLecvel2)
        {
            Console.WriteLine("BINGO!\nYou've guest it!");
            Console.WriteLine("Do you want to play again?");
            string answear = Console.ReadLine();
            switch (answear)
            {
                case "Yes":
                    Console.WriteLine("Do you want play level 1 or level 2? Type 1 or 2");
                    char answear3 = char.Parse(Console.ReadLine());
                    if (answear3 == '1')
                    {
                        isMatch = false;
                        isMatchLevel2 = true;
                        playAgain = false;
                        computerNumber = randomNumber.Next(1, 101);
                    }
                    else
                    {
                        wrongTriestLevel2 = 5;
                        Console.WriteLine("Good luck!");
                        computerNumberLecvel2 = randomNumber.Next(1, 201);
                        break;
                    }
                    break;
                case "No":
                    Console.WriteLine("Thanks for playing!\nBye bye!");
                    isMatchLevel2 = true;
                    playAgain = true; 
                    break;
            }
        }
        else if (playerNumber > computerNumberLecvel2)
        {
            Console.WriteLine("Too high");
            wrongTriestLevel2--;
            Console.WriteLine($"You got: {wrongTriestLevel2} tries left");
            if (wrongTries == 0)
            {
                Console.WriteLine("Game over");
                Console.WriteLine("Do you want to play again?");
                string answear = Console.ReadLine();
                switch (answear)
                {
                    case "Yes":
                        wrongTriestLevel2 = 5;
                        computerNumberLecvel2 = randomNumber.Next(1, 201);
                        break;

                    case "No":
                        Console.WriteLine("Thanks for playing!\nBye bye!");
                        playAgain = true;
                        return;
                }
                break;
            }
        }
        else
        {
            Console.WriteLine("Too low");
            wrongTriestLevel2--;
            Console.WriteLine($"You got: {wrongTriestLevel2} tries left");
            if (wrongTriestLevel2 == 0)
            {
                Console.WriteLine("Game over");
                Console.WriteLine("Do you want to play again?");
                string answear = Console.ReadLine();
                switch (answear)
                {
                    case "Yes":
                        wrongTriestLevel2 = 5;
                        computerNumberLecvel2 = randomNumber.Next(1, 201);
                        break;

                    case "No":
                        Console.WriteLine("Thanks for playing!\nBye bye!");
                        playAgain = true;
                        return;
                }
            }
        }
    }
}