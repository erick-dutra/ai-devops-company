# Use the official .NET 8 runtime as base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# Use the official .NET 8 SDK for building
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj files and restore dependencies
COPY ["src/API/AIDevOpsCompany.API/AIDevOpsCompany.API.csproj", "src/API/AIDevOpsCompany.API/"]
COPY ["src/Core/AIDevOpsCompany.Core/AIDevOpsCompany.Core.csproj", "src/Core/AIDevOpsCompany.Core/"]
COPY ["src/Infrastructure/AIDevOpsCompany.Infrastructure.Data/AIDevOpsCompany.Infrastructure.Data.csproj", "src/Infrastructure/AIDevOpsCompany.Infrastructure.Data/"]
COPY ["src/Infrastructure/AIDevOpsCompany.Infrastructure.Messaging/AIDevOpsCompany.Infrastructure.Messaging.csproj", "src/Infrastructure/AIDevOpsCompany.Infrastructure.Messaging/"]
COPY ["src/Agents/AIDevOpsCompany.Agents.ProjectManagement/AIDevOpsCompany.Agents.ProjectManagement.csproj", "src/Agents/AIDevOpsCompany.Agents.ProjectManagement/"]

RUN dotnet restore "src/API/AIDevOpsCompany.API/AIDevOpsCompany.API.csproj"

# Copy all source code
COPY . .

# Build the application
WORKDIR "/src/src/API/AIDevOpsCompany.API"
RUN dotnet build "AIDevOpsCompany.API.csproj" -c Release -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish "AIDevOpsCompany.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Final stage
FROM base AS final
WORKDIR /app

# Install curl for health checks
RUN apt-get update && apt-get install -y curl && rm -rf /var/lib/apt/lists/*

# Copy published application
COPY --from=publish /app/publish .

# Create non-root user
RUN adduser --disabled-password --gecos '' appuser && chown -R appuser /app
USER appuser

# Set environment variables
ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_ENVIRONMENT=Production

ENTRYPOINT ["dotnet", "AIDevOpsCompany.API.dll"]

