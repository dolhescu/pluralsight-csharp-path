using BookNestHRM.Models;

namespace BookNestHRM.Data;

/// <summary>
/// Provides in-memory storage and operations for managing BookNestEmployee entities.
/// </summary>
public static class EmployeeRepository
{
    private static readonly List<BookNestEmployee> _employees = [];
    private static int _nextId = 1;

    /// <summary>
    /// Adds a new employee to the repository and assigns a unique ID.
    /// </summary>
    /// <param name="employee">The employee to add (without Id).</param>
    /// <returns>The added employee with a generated ID.</returns>
    public static BookNestEmployee Add(BookNestEmployee employee)
    {
        employee.Id = _nextId++;
        _employees.Add(employee);
        return employee;
    }
    /// <summary>
    /// Returns all stored employees.
    /// </summary>
    public static IReadOnlyList<BookNestEmployee> GetAll() => _employees.AsReadOnly();

    /// <summary>
    /// Finds an employee by ID.
    /// </summary>
    /// <param name="id">The employee's unique identifier.</param>
    /// <returns>The employee if found; otherwise, null.</returns>
    public static BookNestEmployee? FindById(int id)
    {
        return _employees.FirstOrDefault(e => e.Id == id);
    }

    /// <summary>
    /// Deletes an employee by ID.
    /// </summary>
    /// <param name="id">The ID of the employee to delete.</param>
    /// <returns>True if the employee was found and removed; otherwise, false.</returns>
    public static bool Delete(int id)
    {
        var employee = FindById(id);
        if (employee is null)
            return false;

        return _employees.Remove(employee);
    }

}
