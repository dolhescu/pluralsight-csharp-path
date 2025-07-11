using BookNestHRM.Models;
using BookNestHRM.Utils;
using BookNestHRM.Data;

namespace BookNestHRM.Features;

/// <summary>
/// Handles the creation of a new BookNestEmployee by collecting input from the console.
/// </summary>
public class CreateEmployeeHandler
{
    /// <summary>
    /// Starts the process of creating a new employee and stores it in the repository.
    /// Displays a confirmation message in the console.
    /// </summary>
    public static void Handle()
    {
        Console.WriteLine("=== Create New Employee ===");

        string firstName = ConsoleInputHelper.ReadNonEmptyInput("First name");
        string lastName = ConsoleInputHelper.ReadNonEmptyInput("Last name");
        string email = ConsoleInputHelper.ReadNonEmptyInput("Email");

        var employee = new BookNestEmployee
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email
        };

        var saved = EmployeeRepository.Add(employee);

        Console.WriteLine("Employee created successfully:");
        Console.WriteLine($"→ {saved.Id}: {saved.FirstName} {saved.LastName} ({saved.Email})");
        Console.WriteLine();
    }
}
