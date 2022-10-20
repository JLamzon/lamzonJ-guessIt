//Jessie Lamzom
//10/19/22
//




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

    if (pickLevel == "custom")
    {
        Random customGame = new Random();
        int customMode = 0;


        Console.WriteLine("Choose your minimum 'starting' number");
        //minCustom = Convert.ToInt32(Console.ReadLine());
        minCustom = Console.ReadLine();
        realNum = Int32.TryParse(minCustom, out customMin);
        Console.WriteLine(realNum);

        Console.WriteLine("Choose your maximum 'ending' number");
        //maxCustom = Convert.ToInt32(Console.ReadLine());
        maxCustom = Console.ReadLine();
        realNum = Int32.TryParse(maxCustom, out customMax);
        Console.WriteLine(realNum);

        customMode = customGame.Next(customMin, customMax + 1);

        while (guess != customMode)
        {

            Console.WriteLine($"{userName} Guess a number between {customMin} to {customMax}");
            //guess = Convert.ToInt32(Console.ReadLine());
            string userGuess = Console.ReadLine();
            realNum = Int32.TryParse(userGuess, out guess);
            Console.WriteLine($"Guess {guess}");

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
            guess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Guess {guess}");
            if (guess > easyMode)
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
            // bool trueNum;
            // int realNormalNumber;

            Console.WriteLine($"{userName}, Guess a number between {minNormal} to {maxNormal}");
            guess = Convert.ToInt32(Console.ReadLine());
            //trueNum = Int32.TryParse(guess, out realNormalNumber);

            Console.WriteLine($"Guess {guess}");
            if (guess > minNormal)
                if (guess > normalMode)
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
            guess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Guess {guess}");
            if (guess > hardMode)
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
    Console.WriteLine("\nTry again? Press enter or type 'no' to exit");
    response = Console.ReadLine().ToLower();

    if (response == "no")
    {
        Console.WriteLine($"{userName}, thanks for playing!");
        playAgain = false;
    }


}