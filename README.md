# SchoolLab Manager

SchoolLab Manager is a Windows Forms inventory and loan management system for a school computer lab. It tracks lab assets, users, loans, returns, overdue loans, and damage reports with role-based access.

## Project Structure

```text
SchoolLabManager/
  SchoolLab.Core/        Models and enums
  SchoolLab.Data/        EF Core DbContext and repositories
  SchoolLab.Services/    Business logic services
  SchoolLab.WinFormsUI/  Windows Forms application
  SchoolLab.Test/        Unit tests
```

The root solution file is:

```text
Software-Development-Project.sln
```

There is also a project-level solution inside:

```text
SchoolLabManager/SchoolLabManager.sln
```

## Technologies

- C#
- .NET Windows Forms
- Entity Framework Core
- SQL Server LocalDB
- NUnit tests

## Requirements

### Minimum Device Specs

- CPU: 64-bit dual-core processor
- RAM: 4 GB minimum
- Storage: 500 MB free space for the app, database, and demo data

### Operating System

- Windows 10 or newer
- Windows 11 recommended

### Required Software For Development

- Visual Studio 2022 or newer with the `.NET desktop development` workload
- .NET SDK compatible with the project target framework
- SQL Server LocalDB, included with Visual Studio or SQL Server Express LocalDB

### Required Software For Running The Release

- The self-contained release in `.\release` can run without installing the .NET Desktop Runtime separately.
- SQL Server LocalDB is still required because the app uses the local `SchoolLabDB` database.

## Main Features

### Login and registration

- Login with hashed passwords.
- Public registration from the login screen.
- New registered users are created as `Viewer`.

### Roles

- Role-based dashboard visibility.
- Viewer users can only see their own loans.
- Admin-only user management.
- Users are displayed in three role columns: Administrator, Lab Assistant, Viewer.

### Main Objects

- Asset listing, details, creation, deletion, and editing.
- Loan creation and return workflow.
- Loan status filter: `All`, `Active`, `Returned`, `Overdue`, `ReturnedLate`.
- Damage report creation, deletion, and admin/lab-assistant editing.

### Seeders

- Automatic check for an existing DB at launch, if no DB exist one is created and seeded.
- Lightweight seeder that could be replaced instead of the showcase seeder.
- Showcase database seeding with demo users, assets, loans, and reports.

## User Roles

### Administrator

Administrators can manage assets, loans, reports, and users. They can also change user roles.

### Lab Assistant

Lab assistants can manage assets, loans, returns, and damage reports.

### Viewer

Viewers have limited access. They can view assets and see only their own loans.

## Demo Login Accounts

The current startup code uses `ShowcaseDatabaseSeeder`, so an empty database will be seeded with showcase data.

### Administrators

```text
AdminTestUser / admin123
MorganAdmin / admin123
```

### Lab Assistants

```text
AssistantTestUser / labassist123
SamAssistant / labassist123
```

### Viewers

```text
ViewerTestUser / viewer123
AvaStudent / viewer123
NoahStudent / viewer123
MiaStudent / viewer123
LeoStudent / viewer123
SofiaStudent / viewer123
```

The same list is also saved in:

```text
ShowcaseLogins.txt
```

## Database

The app uses SQL Server LocalDB with this database name:

```text
SchoolLabDB
```

The connection string is configured in `SchoolLabDbContext` and in `Program.cs`:

```text
Server=(localdb)\mssqllocaldb;Database=SchoolLabDB;Trusted_Connection=true;
```

## Resetting the Database

To reset the database so it is empty and gets reseeded on the next app run, use SQL Server tooling such as Visual Studio SQL Server Object Explorer, Package manager console, or `sqlcmd`.

Example with `Package manager console`:

```powershell
Drop-Database
```

Example with `sqlcmd`:

```powershell
sqlcmd -S "(localdb)\mssqllocaldb" -Q "DROP DATABASE SchoolLabDB"
```

Then run the app again. The database will be created and seeded.

## Switching Seeders

The app currently calls:

```csharp
ShowcaseDatabaseSeeder.Seed(ctx);
```

from `SchoolLab.WinFormsUI/Program.cs`.

To use the smaller original seed data instead, change that line to:

```csharp
DatabaseSeeder.Seed(ctx);
```

After switching seeders, reset the database before running the app again.

## Build and Run

To build the project from the repository root:

```powershell
dotnet build .\Software-Development-Project.sln
```

To run the WinForms app, open the solution in Visual Studio and start the `SchoolLab.WinFormsUI` project.

Alternatively extract the .zip file inside `.\release` and run `SchoolLab.WinFormsUI.exe`.
This is a self-contained release and does not require the installation of .NET Desktop Runtime.

## Tests

The test project is:

```text
SchoolLabManager/SchoolLab.Test
```

Run tests with:

```powershell
dotnet test .\Software-Development-Project.sln
```
