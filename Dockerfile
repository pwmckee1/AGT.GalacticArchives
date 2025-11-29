# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy solution and project files
COPY ["AGT.GalacticArchives.sln", "."]
COPY ["AGT.GalacticArchives.Api/AGT.GalacticArchives.Api.csproj", "AGT.GalacticArchives.Api/"]
COPY ["AGT.GalacticArchives.Core/AGT.GalacticArchives.Core.csproj", "AGT.GalacticArchives.Core/"]
COPY ["AGT.GalacticArchives.Services/AGT.GalacticArchives.Services.csproj", "AGT.GalacticArchives.Services/"]
COPY ["AGT.GalacticArchives.Managers/AGT.GalacticArchives.Managers.csproj", "AGT.GalacticArchives.Managers/"]
COPY ["AGT.GalacticArchives.Globalization/AGT.GalacticArchives.Globalization.csproj", "AGT.GalacticArchives.Globalization/"]

# Restore dependencies
RUN dotnet restore "AGT.GalacticArchives.Api/AGT.GalacticArchives.Api.csproj"

# Copy source code
COPY . .

# Build the application
RUN dotnet build "AGT.GalacticArchives.Api/AGT.GalacticArchives.Api.csproj" -c Release -o /app/build

# Publish stage
FROM build AS publish
RUN dotnet publish "AGT.GalacticArchives.Api/AGT.GalacticArchives.Api.csproj" -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app

# Copy published application
COPY --from=publish /app/publish .

# Cloud Run requires port 8080
ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_ENVIRONMENT=Production

# Health check
HEALTHCHECK --interval=30s --timeout=3s --start-period=40s --retries=3 \
    CMD wget --no-verbose --tries=1 --spider http://localhost:8080/health || exit 1

ENTRYPOINT ["dotnet", "AGT.GalacticArchives.Api.dll"]