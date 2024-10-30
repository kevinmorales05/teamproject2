# Use the official .NET image as the base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Copy the SQLite database file
COPY Team2Project.db /app/

# Build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Team2Project.csproj", "./"]
RUN dotnet restore "Team2Project.csproj"
COPY . .
RUN dotnet publish "Team2Project.csproj" -c Release -o /app/publish

# Final stage/image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Team2Project.dll"]
