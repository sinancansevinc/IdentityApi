# Identity API using .NET 8 Preview

This repository contains an Identity API project built with .NET 8 Preview, showcasing the updated Identity package. The project demonstrates how to create a secure authentication and authorization system using ASP.NET Core Identity.

## Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [Database Setup](#database-setup)

## Features

- **Identity Management**: Utilizes Microsoft.AspNetCore.Identity.EntityFrameworkCore to manage user accounts and roles.
- **Database Integration**: Uses Microsoft.EntityFrameworkCore.SqlServer for database operations.
- **Entity Framework Tools**: Includes Microsoft.EntityFrameworkCore.Tools for migrations and database updates.

## Getting Started

Follow these steps to set up and run the Identity API project on your local machine.

### Prerequisites

- [.NET 8 Preview](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) (or any other code editor of your choice)
- SQL Server or SQL Server Express

### Installation

1. Clone the repository to your local machine:

   ```bash
   git clone https://github.com/sinancansevinc/IdentityApi.git

## Usage

The Identity API provides a foundation for user authentication and authorization. You can customize and expand it to suit your project's needs. Explore the API endpoints and use them in your applications.

## Database Setup

To set up the database for this project, follow these steps:

1. Open the `appsettings.json` file located in the project's root directory.
2. Locate the `"ConnectionStrings"` section within the file and replace "your-connection-string-here" with the connection string specific to your database.

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "your-connection-string-here"
   }
   
3. Run the following command to create a new migration. Replace `{migrationName}` with an appropriate name for your migration:

   ```bash
   dotnet ef migrations add {migrationName}

4. After creating the migration, apply it to the database by running the following command:
    
   ```bash
    dotnet ef database update
