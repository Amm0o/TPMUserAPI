# Generate the Project

> dotnet new webapi -n UserAPI

# Dependencies:

> dotnet tool install --global dotnet-ef --> Install the enetity framework
> dotnet add package Microsoft.EntityFrameworkCore.SqlServer
> dotnet add package Microsoft.EntityFrameworkCore.Design
> dotnet add package Microsoft.EntityFrameworkCore --> Add entity framework
> dotnet add package Microsoft.EntityFrameworkCore.SqlServer --> Add Sql server

# Migrations

> dotnet ef migrations add InitialCreate
> dotnet ef database update

# How to run it:

> donet run
