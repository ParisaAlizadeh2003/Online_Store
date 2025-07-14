# Sperolina Online Store

## Overview
**Sperolina Online Store** is a modern e-commerce web application built with ASP.NET Core 6 using Razor Pages. It follows a Clean Architecture approach, separating concerns into layers (Presentation, Application, Domain, Persistence). The project is designed for flexibility and scalability, leveraging microservices-style principles as noted in the repository description. In this store, customers can browse products by category, add items to a shopping cart, and complete purchases through a checkout process.

---

## Core Features
* **Product Catalog & Categories:** Browse a catalog of products organized into categories. Each product has a name, description, price (with currency) and stock quantity.
* **Product Details:** View detailed information for each product (including a Money value object for amount and currency).
* **Shopping Cart:** Select products to add to a shopping cart (maintaining quantities) before checkout.
* **Checkout & Orders:** Place an order to purchase the items in the cart. Placing an order creates an Order record in the system (the domain includes an Order entity). Customers can view past orders in the Orders page.
* **Category Management:** Products are grouped by categories (with a Category entity) so users can filter or browse by category.
* **Admin Operations:** The application supports creating and managing products and categories (CRUD operations via forms or API). For example, new products can be added by sending a `POST /products` request with the product details.
* **Responsive UI:** The front-end UI uses Bootstrap for layout and is mobile-friendly. Razor Pages are used throughout (e.g., under `Pages/Products` and `Pages/Orders`).
* **Architecture Patterns:** The code implements CQRS/MediatR for commands and queries, and FluentValidation for input validation, ensuring a robust and maintainable codebase.

---

## Technologies
This project follows a **layered (Clean Architecture)** pattern and uses the following technologies:

* **Framework:** ASP.NET Core 6 with Razor Pages for the web UI.  
    [Learn More](https://learn.microsoft.com/en-us/aspnet/core/razor-pages)
* **Programming Languages:** C# for server-side code; HTML/CSS/Bootstrap and minimal JavaScript for the UI.
* **ORM & Database:** Entity Framework Core 6 with a SQL Server database (Code-First migrations). The Money struct in the domain handles multi-currency prices.
* **Libraries:** MediatR for implementing the CQRS (Commands/Queries) pattern, and FluentValidation for declarative validation rules.
* **Dependency Injection:** Built-in ASP.NET Core DI container is used (services registered in `Startup.ConfigureServices`).
* **Testing & CI:** xUnit and Moq are used in the `Shop.Tests` project for unit tests (scaffolded in the solution). A GitHub Actions workflow can run tests on pull requests.
* **Tools:** .NET 6 SDK, Visual Studio (or VS Code), and SQL Server (or LocalDB). (A GitHub repository includes a LICENSE file indicating MIT License.)

---

## Getting Started

### Prerequisites
* .NET 6 SDK
* A suitable IDE (e.g., Visual Studio 2022 or VS Code)
* SQL Server (or SQL Express/LocalDB)

### Steps
1.  **Clone the Repository:**
    ```bash
    git clone [https://github.com/PariCoderDeveloper/Online_Store.git](https://github.com/PariCoderDeveloper/Online_Store.git)
    cd Online_Store
    ```
2.  **Configure Database:** In `Shop.Presentation/appsettings.json`, update the `DefaultConnection` string to point to your SQL Server instance.
3.  **Run EF Migrations:** Open a command prompt in the `Shop.Persistence` folder and execute:
    ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    ```
    This will create the database and schema (see the `Shop.Persistence/Migrations` folder). The `ApplicationDbContext.OnModelCreating` method includes seed data if defined.
4.  **Build and Run:** Start the web application by running the presentation project. For example, in the solution root:
    ```bash
    cd Shop.Presentation
    dotnet run
    ```
    This launches the website (by default on `https://localhost:5001`).
5.  **Access the App:** Open a browser and navigate to the local URL (e.g., `https://localhost:5001`). You should see the home page or a list of products. Navigate through the site (e.g., Products page, Cart/Orders) to use the store.

---

## Project Structure
The solution is organized into multiple projects (layers) as follows:
