# BookNest HRM (Human Resource Management)

A simple, console-based Human Resource Management System for managing employees in a fictional bookstore called **BookNest**.

---

## Features

- Add a new employee
- List all employees
- Update employee details
- Delete an employee
- All data is stored in-memory (non-persistent)

---

## How to Run

1. Navigate to the project directory:

   ```bash
   cd 02-BookNestHRM
   ```

2. Build and run the app:

   ```bash
   dotnet build
   dotnet run
   ```

---

## Architecture Overview

This project follows a vertical slice architecture:

- `Program.cs` – entry point and menu
- `Features/` – one handler per operation (Create, Read, Update, Delete)
- `Data/` – in-memory repository (`EmployeeRepository`)
- `Models/` – core domain model (`BookNestEmployee`)
- `Utils/` – shared console utilities

---

## Notes

This app is purely educational and does not persist data between runs. Future extensions could include file-based or database persistence.
