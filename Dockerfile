# Use official .NET SDK image to build the app
# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copy solution file
COPY ["Logindashboarditem.sln", "./"]

# Copy project files
COPY ["Logindashboarditem/Logindashboarditem.csproj", "Logindashboarditem/"]
COPY ["UtilityOperation/UtilityOperation.csproj", "UtilityOperation/"]

# Restore dependencies
RUN dotnet restore

# Copy all source code
COPY . .

# Publish
RUN dotnet publish "Logindashboarditem/Logindashboarditem.csproj" -c Release -o /app/out

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app

COPY --from=build /app/out .

EXPOSE 80

ENTRYPOINT ["dotnet", "Logindashboarditem.dll"]