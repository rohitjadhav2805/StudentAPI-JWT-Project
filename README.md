# Student Management System API

This project is a Student Management System developed using ASP.NET Core Web API and SQL Server.

It was created as part of a technical assignment.

---

## Project Description

This application is used to manage student records. It provides basic CRUD operations like adding, updating, viewing, and deleting students.

The project also includes authentication and proper API structure.

---

## Features

- Add new student
- View all students
- Update student details
- Delete student
- JWT login authentication
- Global error handling
- Swagger API documentation

---

## Technologies Used

- ASP.NET Core Web API (.NET 8)
- SQL Server
- Entity Framework Core
- JWT Authentication
- Swagger

---
## Database Setup

This project uses SQL Server database with Entity Framework Core (Code First approach).

### Table: Students

The Students table is created automatically using migrations.

### Fields:

- Id (Primary Key, Auto Increment)
- Name (nvarchar)
- Email (nvarchar)
- Age (int)
- Course (nvarchar)
- CreatedDate (datetime)

---

### Auto Increment (Identity Column)

The Id column is set as Identity (Auto Increment).

So you do NOT need to pass Id while adding a new student.

Example:
Correct JSON for POST:
{
  "name": "Rahul",
  "email": "rahul@gmail.com",
  "age": 22,
  "course": "IT"
}

*# Do NOT send Id manually.
---

## Authentication

JWT authentication is used for secure access.

Login credentials:
- Username: admin
- Password: admin123

After login, token is used to access APIs.

---

## API Endpoints

- POST /api/auth/login
- GET /api/students
- POST /api/students
- PUT /api/students/{id}
- DELETE /api/students/{id}

---

## How to Run Project

1. Clone the repository
2. Update connection string in appsettings.json
3. Run database migration using EF Core
4. Start project using:
   dotnet run
5. Open Swagger in browser:
   https://localhost:7227/swagger

---

## Note

This project is developed for assignment and learning purpose.

---

## Author

Rohit Jadhav
