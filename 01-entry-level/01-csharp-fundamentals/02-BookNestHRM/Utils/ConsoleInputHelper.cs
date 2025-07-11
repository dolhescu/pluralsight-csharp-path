namespace BookNestHRM.Utils;

/// <summary>
/// Provides helper methods for safely reading user input from the console.
/// </summary>
public static class ConsoleInputHelper
{
    /// <summary>
    /// Prompts the user with a label and reads a non-empty input from the console.
    /// The prompt is repeated until a valid (non-empty, non-whitespace) string is entered.
    /// </summary>
    /// <param name="label">The label to display before reading the input.</param>
    /// <returns>A trimmed, non-empty string entered by the user.</returns>
    public static string ReadNonEmptyInput(string label)
    {
        string? input;

        do
        {
            Console.Write($"{label}: ");
            input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Input cannot be empty. Please try again.");
            }

        } while (string.IsNullOrWhiteSpace(input));

        return input.Trim();
    }
}
