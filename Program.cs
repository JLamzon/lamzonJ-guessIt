//Jessie Lamzom
//10/20/22
//GitHubChallenge - Redo mini Challenges
// Guess It - data validation and play again
//Peer Review by Amardeep Mann: Good work with 
// the play-again feature. Using the while loop was a great call for that. 
// Choosing the game mode works well enough. For future evesions you may want 
// to throw in a data validation to make sure the user picks a valid difficulty 
// instead of going straight to "Play Again?" if they don't. The custom game mode 
// also works pretty great. The only way I was able to break it is if I choose a 
// aximum number that's lower than the min. You may want to add a check in the future 
// to account for users being idiots since it will crash the program. All in all great 
// work! I appreciates how you ask the user for their name to make for a more interactive 
// experience


Console.Clear();

string response;
bool playAgain = true;
int min = 1;
int max = 10;
int minNormal = 1;
int maxNormal = 50;
int minHard = 1;
int maxHard = 100;
int customMin = 0;
int customMax = 0;
string minCustom;
string maxCustom;

int easyMode;
int normalMode;
int hardMode;
int guesses;
int guess;

Random easyGame = new Random();
Random normalGame = new Random();
Random hardGame = new Random();

string pickLevel = "";
string userName = "";

Console.WriteLine("Lets play 'Guess The Number' Game!\n");
Console.WriteLine("Before we start, enter your name.");
userName = Console.ReadLine().ToUpper();

while (playAgain != false)
{
    Console.WriteLine("");
    Console.WriteLine("Please choose a level\nEasy, Normal, Hard, or challenge yourself with Custom!\n");
    pickLevel = Console.ReadLine().ToLower();

    guess = 0;
    guesses = 0;
    response = "";
    easyMode = easyGame.Next(min, max + 1);
    normalMode = normalGame.Next(minNormal, maxNormal + 1);
    hardMode = hardGame.Next(minHard, maxHard + 1);
    bool realNum = true;
    int customMode = 0;

    if (pickLevel == "custom")
    {
        while (true)
        {
            Console.WriteLine("Choose your minimum 'starting' number");
            minCustom = Console.ReadLine();
            realNum = Int32.TryParse(minCustom, out customMin);

            if (realNum == false)
            {
                Console.WriteLine("Try entring a number...");
            }
            else
            {
                break;
            }
        }

        while (true)
        {
        Console.WriteLine("Choose your maximum 'ending' number\n");
        maxCustom = Console.ReadLine();
        realNum = Int32.TryParse(maxCustom, out customMax);

        if (realNum == false)
        {
            Console.WriteLine("Try entering a number...");
        }
        else
        {
            break;
        }
    }

    Random customGame = new Random();
    customMode = customGame.Next(customMin, customMax + 1);

    while (guess != customMode)
    {
        Console.WriteLine($"{userName} Guess a number between {customMin} to {customMax}");
        string userGuess = Console.ReadLine();
        realNum = Int32.TryParse(userGuess, out guess);

        if (realNum == false)
        {
            Console.WriteLine("Try entering numbers only...");
        }
        else if (guess < customMin || guess > customMax)
        {
            Console.WriteLine("Please stay within Custom range");
        }
        else if (guess > customMode)
        {
            Console.WriteLine($"{guess} is too high");
        }
        else if (guess < customMode)
        {
            Console.WriteLine($"{guess} is too low");
            Console.WriteLine("Try again");
        }
        guesses++;
    }
    Console.WriteLine("");
    Console.WriteLine("Ohhh you got me! Good game! :)");
    Console.WriteLine($"Number {customMode}");
    Console.WriteLine($"Guesses: {guesses}");

}
if (pickLevel == "easy")
{
    while (guess != easyMode)
    {
        Console.WriteLine($"{userName}, Guess a number between {min} to {max}");
        string userGuess = Console.ReadLine();
        realNum = Int32.TryParse(userGuess, out guess);

        if (realNum == false)
        {
            Console.WriteLine("Try entering numbers only...");
        }
        else if (guess > easyMode)
        {
            Console.WriteLine($"{guess} is too high");
        }
        else if (guess < easyMode)
        {
            Console.WriteLine($"{guess} is too low");
            Console.WriteLine("Try again");
        }
        guesses++;
    }
    Console.WriteLine("Dang! You beat me!");
    Console.WriteLine($"Number {easyMode}");
    Console.WriteLine($"Guesses: {guesses}");
}
else if (pickLevel == "normal")
{
    while (guess != normalMode)
    {
        Console.WriteLine($"{userName}, Guess a number between {minNormal} to {maxNormal}");
        string userGuess = Console.ReadLine();
        realNum = Int32.TryParse(userGuess, out guess);

        if (realNum == false)
        {
            Console.WriteLine("Try entering numbers only...");
        }
        else if (guess > normalMode)
        {
            Console.WriteLine($"{guess} is too high");
        }
        else if (guess < normalMode)
        {
            Console.WriteLine($"{guess} is too low");
            Console.WriteLine("Try again");
        }
        guesses++;
    }
    Console.WriteLine("Sweet! You're good!");
    Console.WriteLine($"Number {normalMode}");
    Console.WriteLine($"Guesses: {guesses}");
}
else if (pickLevel == "hard")
{
    while (guess != hardMode)
    {
        Console.WriteLine($"{userName}, Guess a number between {minHard} to {maxHard}");
        string userGuess = Console.ReadLine();
        realNum = Int32.TryParse(userGuess, out guess);

        if (realNum == false)
        {
            Console.WriteLine("Try entering numbers only...");
        }
        else if (guess > hardMode)
        {
            Console.WriteLine($"{guess} is too high");
        }
        else if (guess < hardMode)
        {
            Console.WriteLine($"{guess} is too low");
            Console.WriteLine("Try again");
        }
        guesses++;
    }
    Console.WriteLine("WOO! Give yourself hand!");
    Console.WriteLine($"Number {hardMode}");
    Console.WriteLine($"Guesses {guesses}");
}
Console.WriteLine("\nPress any key to play again or type 'no' to exit...");
response = Console.ReadLine().ToLower();

if (response == "no")
{
    Console.WriteLine($"{userName}, thanks for playing!");
    playAgain = false;
}
}