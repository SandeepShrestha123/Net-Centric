# NET Centric Computing Lab

This repository contains my lab work for **NET Centric Computing (NCC)**, built with C# and ASP.NET Core using Visual Studio Community.

Labs 1 to 10 cover core C# concepts as console programs. Labs 11 to 20 cover web development with ASP.NET Core MVC, Web API, Entity Framework Core, Identity and web security.

## Lab List

| Lab | Title | Folder |
| --- | --- | --- |
| 1 | Student Class using Auto-Implemented Properties | `Lab1_StudentCLass` |
| 2 | Runtime Polymorphism using Shape, Circle, Rectangle | `lab2-10` |
| 3 | Indexer Implementation in Week Class | `lab2-10` |
| 4 | Generic Stack&lt;T&gt; Class with Push, Pop, Peek | `lab2-10` |
| 5 | Abstract Class Employee with CalculateSalary() | `lab2-10` |
| 6 | Interface IPayable Implemented Polymorphically | `lab2-10` |
| 7 | Delegates and Events for Temperature Threshold | `lab2-10` |
| 8 | LINQ and Lambda Expressions for Filtering Integers | `lab2-10` |
| 9 | File I/O using StreamReader/StreamWriter with Exception Handling | `lab2-10` |
| 10 | Asynchronous Programming using async/await | `lab2-10` |
| 11 | Creating an ASP.NET Core MVC Project (`dotnet new mvc`) | `Lab11_MvcDemo` |
| 12 | ProductController with Index Action and Razor View | `Lab12_...` |
| 13 | Razor Syntax and Tag Helpers in a Registration Form | `Lab13_TagHelpers` |
| 14 | Employee Model with Data Annotations and Validation | `Lab14_EmployeeValidation` |
| 15 | Custom URL Routing in ASP.NET Core MVC | `Lab15_CustomRouting` |
| 16 | Web API Controller with GET and POST Endpoints | `Lab16_WebApi` |
| 17 | Entity Framework Core CRUD Operations on Book Entity | `Lab17_EFCoreBook` |
| 18 | Session State Management Across Actions/Pages | `Lab18_SessionDemo` |
| 19 | Authentication and Authorization using ASP.NET Core Identity | `Lab19_IdentityAuth` |
| 20 | Parameterized Query vs SQL Injection Demonstration | `Lab20_SqlInjection` |

## Technologies Used

- C# and .NET
- ASP.NET Core MVC and Razor
- ASP.NET Core Web API
- Entity Framework Core
- ASP.NET Core Identity
- LINQ
- Visual Studio Community

## How to Run a Lab

1. Clone the repository:
   ```bash
   git clone https://github.com/SandeepShrestha123/Net-Centric.git
   ```
2. Open the folder of the lab you want, for example:
   ```bash
   cd Net-Centric/Lab11_MvcDemo
   ```
3. Run the project:
   ```bash
   dotnet run
   ```
4. For web projects, open the URL shown in the terminal (for example `https://localhost:5001`).

Alternatively, open the `.sln` or `.csproj` file in Visual Studio and press **F5**.

## Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) (the version used by each project's `.csproj`)
- Visual Studio 2022 or later (optional)

Local database files (`*.db`) are not included in the repository. Labs that use a database (17 and 19) create it when you run the migrations or the app.

## Author

**Sandeep Shrestha**
GitHub: [SandeepShrestha123](https://github.com/SandeepShrestha123)
