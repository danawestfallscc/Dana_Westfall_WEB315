dotnet new webapp -o creativeBlooms
code -r creativeBlooms
dotnet dev-certs https --trust
dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.13
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 5.0.13
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.13
dotnet watch run
ctrl+c
dotnet-aspnet-codegenerator razorpage -m Flower -dc creativeBloomsFlowerContext -udl -outDir Pages/Movies --referenceScriptLibraries -sqlite
dotnet-aspnet-codegenerator razorpage -h
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet watch run