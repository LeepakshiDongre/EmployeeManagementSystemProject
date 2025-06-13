# EmployeeManagementSystemProject
# 🧑‍💼 Employee Management System (ASP.NET Core MVC)

A simple web-based Employee Management System built using ASP.NET Core MVC, Entity Framework Core, and SQL Server. The system allows HR/admin users to manage employee data with CRUD operations and basic search/sort features.

---

## 📋 Features

- Add new employee  
- View all employees  
- Edit employee details  
- Delete employee  
- View individual employee profile  
- Search by name or department  
- Sort by name or salary  
- Simple admin login using session

---

## 🧰 Technologies Used

- C# with ASP.NET Core MVC  
- Entity Framework Core (database access)  
- SQL Server  
- Razor Views with Bootstrap for UI  
- Git for version control

---

## 🗃️ Database Schema

**Employee Table**

| Field         | Type      |
|---------------|-----------|
| Id            | int (PK)  |
| FullName      | string    |
| Department    | string    |
| Designation   | string    |
| Salary        | decimal   |
| DateOfJoining | DateTime  |

---

## 📁 Project Structure

EmployeeManagementSystem/
├── Controllers/
│ └── EmployeesController.cs
├── Models/
│ └── Employee.cs
├── Views/
│ ├── Employees/
│ │ ├── Index.cshtml
│ │ ├── Create.cshtml
│ │ ├── Edit.cshtml
│ │ ├── Delete.cshtml
│ │ └── Details.cshtml
│ └── Home/
│ ├── Index.cshtml
│ ├── Privacy.cshtml
│ └── Login.cshtml
├── Data/
│ └── ApplicationDbContext.cs
├── wwwroot/
├── appsettings.json

yaml
Copy
Edit

---

## 🚀 Getting Started

1. Clone the repository  
2. Open the project in Visual Studio  
3. Configure the database in `appsettings.json`  
4. Apply migrations  
5. Run the application  

---

## 🔐 Admin Login

- **Username**: admin  
- **Password**: 123  


## 📁 Documentation

This repository includes:

- `README.md` (this file)  
- Project source code 

