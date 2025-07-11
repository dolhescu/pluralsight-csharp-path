using BookNestHRM.Data;
using BookNestHRM.Utils;

namespace BookNestHRM.Features;

/// <summary>
/// Handles the update of an existing BookNestEmployee by collecting new input values from the console.
/// </summary>
public static class UpdateEmployeeHandler
{
    /// <summary>
    /// Prompts the user for an employee ID, locates the employee, and updates their details.
    /// </summary>
    public static void Handle()
    {
        Console.WriteLine("=== Update Employee ===");

        Console.Write("Enter employee ID to update: ");
        var idInput = Console.ReadLine();

        if (!int.TryParse(idInput, out int id))
        {
            Console.WriteLine("Invalid ID. Please enter a valid number.");
            return;
        }

        var employee = EmployeeRepository.FindById(id);
        if (employee is null)
        {
            Console.WriteLine($"No employee found with ID {id}.");
            return;
        }

        Console.WriteLine($"Editing employee: {employee.FirstName} {employee.LastName} ({employee.Email})");

        employee.FirstName = ConsoleInputHelper.ReadNonEmptyInput("New first name");
        employee.LastName = ConsoleInputHelper.ReadNonEmptyInput("New last name");
        employee.Email = ConsoleInputHelper.ReadNonEmptyInput("New email");

        Console.WriteLine("Employee updated successfully.");
        Console.WriteLine($"→ {employee.Id}: {employee.FirstName} {employee.LastName} ({employee.Email})");
        Console.WriteLine();
    }
}
