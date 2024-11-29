using AssignmenObjectConstructors;

decimal result;

string[] menu = [
    "1. Create Account",
    "2. Sign in",
    "4. Exit"
];

Console.WriteLine();

CurrencyConverter setCurrencyRates = new(0.095m, 0.085m, 1);

result = setCurrencyRates.EURToUSD(100);
Console.WriteLine($"100 EUR to USD:     {result:F2} USD");
Console.WriteLine();

result = setCurrencyRates.EURToSEK(100);
Console.WriteLine($"100 EUR to SEK:     {result:C}");
Console.WriteLine();

result = setCurrencyRates.SEKToEUR(100);
Console.WriteLine($"100 SEK to EUR:     {result:F2} EUR");
Console.WriteLine();

User.CreateAccount("Peter", "233");

/*
bool exit = false;
while (!exit)
{
    string? input = Console.ReadLine();

    switch (input)
    {
        case "1":
            User.CreateAccount();
            break;
        case "2":
            User.SignIn();
            break;
        case "3":
            exit = true;
            Console.WriteLine("Exiting the application. Goodbye!");
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
    if (!exit)
    {
        Console.WriteLine("\nPress Enter to return to the menu...");
        Console.ReadLine();
    };
}
*/
