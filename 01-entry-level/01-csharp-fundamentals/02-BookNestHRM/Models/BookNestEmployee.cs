namespace BookNestHRM.Models
{
    /// <summary>
    /// Represents a bookstore employee with basic identity information.
    /// </summary>
    public class BookNestEmployee
    {
        /// <summary>
        /// The unique identifier of the employee.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The first name of the employee.
        /// </summary>
        public required string FirstName { get; set; }

        /// <summary>
        /// The surname (last name) of the employee.
        /// </summary>
        public required string LastName { get; set; }

        /// <summary>
        /// The email address of the employee.
        /// </summary>
        public required string Email { get; set; }
    }
}