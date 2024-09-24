
// добавена опция за максимално допуснати грешки


Random randomNumber = new Random();

int computerNumber = randomNumber.Next(1, 101);
bool isMatch = false;
Console.Write($"Choose any number between 1 - 100: ");
int wrongTries = 0;
while (isMatch == false)
{
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
    }
    else if (playerNumber > computerNumber)
    {
        Console.WriteLine("Too high");
        wrongTries++;
        if (wrongTries == 5)
        {
            Console.WriteLine("Game over");
            break;
        }
    }
    else
    {
        Console.WriteLine("Too low");
        wrongTries++;
        if (wrongTries == 5)
        {
            Console.WriteLine("Game over");
            break;
        }
    }
}
