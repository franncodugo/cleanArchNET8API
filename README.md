# Clean Architecture NET 8 LTS API - cleanArchNET8API
NET 8 LTS Complete API using Clean Architecture and CQRS.


# How to create the entire solution

- 1. Create the solution: dotnet new sln -o EasyAPI
- 2. Create the class libraries: 
    . dotnet new classlib -o Domain -f net8.0
    . dotnet new classlib -o Application -f net8.0
    . dotnet new classlib -o Infrastructure -f net8.0
- 3. Create the Web API project: dotnet new webapi -o Web.API -f net8.0
- 4. Set the relationships:
    - Application -> Domain. (dotnet add Application/Application.csproj reference Domain/Domain.csproj)
    - Infrastructure -> Application. (dotnet add Infrastructure/Infrastructure.csproj reference Application/Application.csproj)
    - Infrastructure -> Domain. (dotnet add Infrastructure/Infrastructure.csproj reference Domain/Domain.csproj)
    - Web API. (dotnet add Web.API/Web.API.csproj reference Application/Application.csproj Infrastructure/Infrastructure.csproj)
- 5. Add all projects to the Solution. (dotnet sln add Web.API/Web.API.csproj Application/Application.csproj Infrastructure/Infrastructure.csprj Domain/Domain.csproj)