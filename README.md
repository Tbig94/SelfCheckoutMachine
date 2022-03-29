# Self Checkout Machine App
### framework: .NET 6.0
### database: MSSQL

### Packages
	Microsoft.EntityFrameworkCore
	Microsoft.EntityFrameworkCore.SqlServer
	Microsoft.EntityFrameworkCore.Tools

### 1. Set the connection string in appsettings.json ("DefaultConnection")

### 2. Seed database(Package manager console):

	 update-database
	 
### 3. Run the app from root folder
	dotnet run


### Endpoints
- #### [POST Stock](https://localhost:7000/api/v1/Stock)
- #### [GET Stock](https://localhost:7000/api/v1/Stock)
- #### [POST Checkout](https://localhost:7000/api/v1/Checkout)
