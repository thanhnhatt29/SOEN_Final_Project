# Sales Management Project

## Introduction
The Sales Management Project is a sales management application developed in C#. This project is designed to assist in managing sales activities, including account management, billing, employee management, product management, and other related activities.

## Project Structure
- **BLL (Business Logic Layer)**: Contains business logic classes.
- **DAL (Data Access Layer)**: Contains data access classes.
- **UI (User Interface)**: Contains user interface classes.

## Main Features
- **Account Management**: Create, update, and delete user accounts.
- **Billing**: Generate and manage bills and bill details.
- **Employee Management**: Manage employee information and roles.
- **Order Management**: Handle customer orders and order details.
- **Product Management**: Manage product information, including adding, updating, and deleting products.
- **Revenue Management**: Track and report revenue.
- **Voucher Management**: Create and manage discount vouchers.
- **Selling History**: View and manage the history of sales transactions.
- **Login and Authentication**: Secure login and authentication for users.

## Installation
1. Clone the repository:
   ```sh
   git clone <repository-url>
   ```
2. Open the solution in Visual Studio
   ```sh
   cd <repository-folder>
   code UI.sln 
   ``` 
3. Restore NuGet packages
   ```sh
   dotnet restore
   ``` 

## Build and run
1. Build the project:
    ```sh
   dotnet build
   ```

1. Build the project:
    ```sh
   dotnet run --project UI/UI.csproj
   ``` 

