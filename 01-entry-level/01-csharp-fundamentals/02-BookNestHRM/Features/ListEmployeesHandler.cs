using BookNestHRM.Data;
using BookNestHRM.Models;

namespace BookNestHRM.Features;

/// <summary>
/// Handles the retrieval and display of all BookNestEmployee records from the repository.
/// </summary>
public static class ListEmployeesHandler
{
    /// <summary>
    /// Displays the list of all employees currently stored.
    /// </summary>
    public static void Handle()
    {
        Console.WriteLine("=== Employee List ===");

        var employees = EmployeeRepository.GetAll();

        if (employees.Count == 0)
        {
            Console.WriteLine("No employees found.");
        }
        else
        {
            foreach (BookNestEmployee employee in employees)
            {
                Console.WriteLine($"{employee.Id}: {employee.FirstName} {employee.LastName} ({employee.Email})");
            }
        }

        Console.WriteLine();
    }
}
