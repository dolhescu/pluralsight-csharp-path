using BookNestHRM.Data;

namespace BookNestHRM.Features;

/// <summary>
/// Handles the deletion of a BookNestEmployee by prompting for a valid ID.
/// </summary>
public static class DeleteEmployeeHandler
{
    /// <summary>
    /// Prompts the user for an employee ID and deletes the corresponding employee if found.
    /// </summary>
    public static void Handle()
    {
        Console.WriteLine("=== Delete Employee ===");

        Console.Write("Enter employee ID to delete: ");
        var idInput = Console.ReadLine();

        if (!int.TryParse(idInput, out int id))
        {
            Console.WriteLine("Invalid ID. Please enter a valid number.");
            return;
        }

        var success = EmployeeRepository.Delete(id);

        if (success)
        {
            Console.WriteLine($"Employee with ID {id} deleted successfully.\n");
        }
        else
        {
            Console.WriteLine($"No employee found with ID {id}.\n");
        }
    }
}
