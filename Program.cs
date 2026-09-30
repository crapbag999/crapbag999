int round = 0;
int cityHealth = 15;
int manticoreHealth = 10;
bool endLoop = false;

Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
int playerOneRange = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine("Player 2, it is your turn.");
Console.WriteLine("-----------------------------------------------------------");

while (endLoop == false)
{
    round++;
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine($"STATUS: Round: {round}\tCity: {cityHealth}/15\tManticore: {manticoreHealth}/10");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"The cannon is expected to deal {FireBolt(round)} damage this round.");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"Enter desired cannon range: ");
    int playerTwoGuess = Convert.ToInt32(Console.ReadLine());
    if (playerOneRange < playerTwoGuess)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("That round OVERSHOT the target.");
    }
    else if (playerOneRange > playerTwoGuess)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("That round FELL SHORT of the target.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("That round was a DIRECT HIT!");
        manticoreHealth -= FireBolt(round);
    }

    if (cityHealth > 0)
    {
        cityHealth--;
    }

    if (manticoreHealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");

        endLoop = true;
    }
    else if (cityHealth <= 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("The City was destroyed…");

        endLoop = true;
    }

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("-----------------------------------------------------------");

}



static int FireBolt(int round)
{
    if (round % 3 == 0 && round % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        return 10;
    }
    else if (round % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        return 3;
    }
    else if (round % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        return 3;
    }
    else
    {
        return 1;
    }
}