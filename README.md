
				CarInventory

Overview:

CarInventory is my capstone project for CODE:You 2024 January Software Development Path. It is C# based CRUD application that manages the invenotory for a car dealer.

Features Utilized:

C# and dotnet: version 8
Blazor-	uses blazor server interactivity render mode
Entity Framework Core- 	 dotnet framework for object-relational mapping(ORM)
SQLite3- database system used for persistence

Getting Started:

1. Download/Update dotnet version 8 from https://learn.microsoft.com/en-us/dotnet/core/install/
2. Download and install Visual Studio 2022 or VSCode
3. Download SQLite3 from https://www.sqlite.org/download.html, extract and add to system path. 
4. Cloning repository using command git clone https://github.com/rameshpokharel21/CarInventory.git
5. Build the solution and let Visual Studio download the related packages. (dotnet build)
6. Run the application (dotnet run).
7. Type the uri with port provided on KestrelServer screen(eg. http://localhost:5163 or https://localhost:7275)

Database Setup: 
ConnectionStrings and Initial Data is provided inside the code.
database commands for .net cli
dotnet tool install --global dotnet-ef
dotnet ef migrations add <MigrationName> (visual studio PM Console: Add-Migration <MigrationName>)
dotnet ef migrations remove (pm console: remove-migration)
dotnet ef database update  (pm console: update-database)
dotnet ef database drop (--force) (visual studio pm console: drop-database)

Dependencies(Packages)
	1. Microsoft.EntityFrameworkCore.SQLite 
	2. Microsoft.EntityFrameworkCore.Tools
	3. Microsoft.EntityFrameworkCore.Design
	4. Microsoft.AspNetCore.Components.QuickGrid

Tests Setup was done using bunit.template:  dotnet new install bunit.template