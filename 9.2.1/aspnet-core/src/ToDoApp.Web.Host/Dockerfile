FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/ToDoApp.Web.Host/ToDoApp.Web.Host.csproj", "src/ToDoApp.Web.Host/"]
COPY ["src/ToDoApp.Web.Core/ToDoApp.Web.Core.csproj", "src/ToDoApp.Web.Core/"]
COPY ["src/ToDoApp.Application/ToDoApp.Application.csproj", "src/ToDoApp.Application/"]
COPY ["src/ToDoApp.Core/ToDoApp.Core.csproj", "src/ToDoApp.Core/"]
COPY ["src/ToDoApp.EntityFrameworkCore/ToDoApp.EntityFrameworkCore.csproj", "src/ToDoApp.EntityFrameworkCore/"]
WORKDIR "/src/src/ToDoApp.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/ToDoApp.Web.Host", "src/ToDoApp.Web.Host"]
COPY ["src/ToDoApp.Web.Core", "src/ToDoApp.Web.Core"]
COPY ["src/ToDoApp.Application", "src/ToDoApp.Application"]
COPY ["src/ToDoApp.Core", "src/ToDoApp.Core"]
COPY ["src/ToDoApp.EntityFrameworkCore", "src/ToDoApp.EntityFrameworkCore"]
WORKDIR "/src/src/ToDoApp.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "ToDoApp.Web.Host.dll"]
