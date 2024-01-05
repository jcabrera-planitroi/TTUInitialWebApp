## Steps to execute this application in local environment

### 1. Clone the repository

### 2. Update Database Connection

Open the `appsettings.json` file and modify the `DefaultConnection` URL to use your local SQL Server. Update your server, username and password as needed.

```json
"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=TTUInitial;User Id=sa;password=admin*2016;MultipleActiveResultSets=true;Encrypt=False"
}
```

### 3. Execute Database Migrations

To update your local Sql Server and create the needed database execute the following command under your project directory. The one that contains the `TTUInitialWebApp.csproj` file
```bash
dotnet ef database update
```

You can also achieve this by executing the following command in your NuGet Console in Visual Studio
```bash
Update-Database
```

### 4. After the migration and update completes. Now you can execute the project as normal using your preferred IDE.
