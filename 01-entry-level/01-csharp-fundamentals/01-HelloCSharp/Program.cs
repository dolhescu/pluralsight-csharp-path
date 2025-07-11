// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

GreetUser();

/// <summary>
/// Reads the user's name from the console and prints a personalized greeting.
/// If the user enters nothing, a default name is used.
/// </summary>
static void GreetUser()
{
    Console.Write("Please enter your name: ");

    string? input = Console.ReadLine();
    string name = string.IsNullOrWhiteSpace(input) ? "anonymous user" : input.Trim();

    Console.WriteLine($"Hello, {name}!");
}
