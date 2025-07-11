using BookNestHRM.Features;
using BookNestHRM.Models;

namespace BookNestHRM;

/// <summary>
/// Entry point for the BookNest HRM console application.
/// Displays a main menu and allows the user to perform basic CRUD operations
/// on BookNestEmployee entities.
/// </summary>
class Program
{
    private static readonly List<BookNestEmployee> _employees = new();

    static void Main()
    {
        Console.WriteLine("Welcome to BookNest HRM - Human Resource Management System");
        Console.WriteLine("----------------------------------------------------------");

        bool exitRequested = false;

        while (!exitRequested)
        {
            ShowMainMenu();

            Console.Write("Select an option: ");
            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateEmployeeHandler.Handle();
                    break;
                case "2":
                    ListEmployeesHandler.Handle();
                    break;
                case "3":
                    UpdateEmployeeHandler.Handle();
                    break;
                case "4":
                    DeleteEmployeeHandler.Handle();
                    break;
                case "5":
                    Console.WriteLine("Exiting BookNest HRM...");
                    exitRequested = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine(); // spacing
        }
    }

    /// <summary>
    /// Displays the main menu options available to the user.
    /// </summary>
    static void ShowMainMenu()
    {
        Console.WriteLine("Please choose an action:");
        Console.WriteLine("1. Create employee");
        Console.WriteLine("2. List employees");
        Console.WriteLine("3. Update employee");
        Console.WriteLine("4. Delete employee");
        Console.WriteLine("5. Exit (all employee data will be lost)");
    }
}
