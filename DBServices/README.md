# DBServices

This is a C# ASP.NET Core Web API project configured to connect to a SQL Server database.

## Database Connection
- **Server:** inch-casemgt1
- **Database:** SympraxisClientGUI_Prod_Trans
- **User:** sa
- **Password:** (set in `appsettings.json`)

## Getting Started

1. Ensure you have the .NET 8 SDK installed.
2. Update the connection string in `appsettings.json` if needed.
3. Run the project:
   ```bash
   dotnet run
   ```

## Project Structure
- `Program.cs`: Main entry point, configures services and middleware.
- `Data/AppDbContext.cs`: Entity Framework Core DB context.
- `appsettings.json`: Configuration, including the SQL Server connection string.

## Security Note
For production, use environment variables or user secrets to store sensitive data like connection strings.
