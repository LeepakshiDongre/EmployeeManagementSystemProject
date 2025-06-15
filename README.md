# EmployeeManagementSystemProject
 🧑‍💼 Employee Management System (ASP.NET Core MVC)

A web-based application built using ASP.NET Core MVC that allows HR/admin users to manage employee records through CRUD operations, search, sort, and admin-only access.

---

## 📌 Project Overview

This project is part of the Wipro NGA .NET Full Stack Capstone program. It focuses on creating a real-world Employee Management Portal that:

- Allows authorized users (admin) to manage employee data
- Supports full CRUD operations
- Includes basic security using session-based login
- Provides a simple and user-friendly interface

---

## ✅ Features

- ➕ Add new employee  
- 📋 View all employees  
- ✏️ Edit employee details  
- 🗑️ Delete employee records  
- 🔍 Search employees by name or department  
- 🔃 Sort employee list by name or salary  
- 🔐 Admin login/logout (session-based)

---

## 🛠️ Technologies Used

| Technology            | Description                        |
|------------------------|------------------------------------|
| ASP.NET Core MVC       | Web application framework          |
| Entity Framework Core  | ORM for database access            |
| SQL Server             | Relational database                |
| Razor Views            | UI rendering                       |
| Bootstrap              | Styling and responsiveness         |
| Git                    | Version control                    |

---

## 🗃️ Database Schema

### Table: `Employee`

| Field Name     | Data Type   |
|----------------|-------------|
| Id             | int (PK)    |
| FullName       | string      |
| Department     | string      |
| Designation    | string      |
| Salary         | decimal     |
| DateOfJoining  | DateTime    |

---

## 🧱 Project Structure

EmployeeManagement/
├── Controllers/
│ └── EmployeesController.cs
├── Models/
│ └── Employee.cs
├── Views/
│ └── Employees/
│ ├── Index.cshtml
│ ├── Create.cshtml
│ ├── Edit.cshtml
│ ├── Details.cshtml
│ └── Delete.cshtml
│ └── Home/
│ ├── Login.cshtml
├── Data/
│ └── ApplicationDbContext.cs
├── wwwroot/
├── appsettings.json

yaml
Copy
Edit

---

## ▶️ Getting Started

### Prerequisites
- Visual Studio 2022 or later
- .NET 6 or above
- SQL Server
- NuGet package restore

### Run Instructions

1. **Clone or Download** the project.
2. Open in Visual Studio.
3. Go to `appsettings.json` and update the connection string for SQL Server.
4. Open Package Manager Console:
    ```
    Add-Migration InitialCreate
    Update-Database
    ```
5. Press `Ctrl + F5` to run the project.

---

## 🔐 Admin Login

- **Username**: `admin`  
- **Password**: `123`

> This is a simple session-based authentication for demo purposes.

---

## 🧪 Screenshots

1. Login Page  
2. Employee List  
3. Add Employee Form  
4. Edit Page  
5. Delete Confirmation  
6. README.md Preview

(Screenshots can be found in `/Screenshots` folder)

---

## 📁 Documentation

This repository includes:

- `README.md` (this file)  
- Project source code  
- Screenshots (optional)  
- Code examples (Model, Controller, View)


