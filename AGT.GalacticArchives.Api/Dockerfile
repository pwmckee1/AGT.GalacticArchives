FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["AGT.GalacticArchives.Api/AGT.GalacticArchives.Api.csproj", "AGT.GalacticArchives.Api/"]
COPY ["AGT.GalacticArchives.Core/AGT.GalacticArchives.Core.csproj", "AGT.GalacticArchives.Core/"]
COPY ["AGT.GalacticArchives.Globalization/AGT.GalacticArchives.Globalization.csproj", "AGT.GalacticArchives.Globalization/"]
COPY ["AGT.GalacticArchives.Services/AGT.GalacticArchives.Services.csproj", "AGT.GalacticArchives.Services/"]
RUN dotnet restore "AGT.GalacticArchives.Api/AGT.GalacticArchives.Api.csproj"
COPY . .
WORKDIR "/src/AGT.GalacticArchives.Api"
RUN dotnet build "./AGT.GalacticArchives.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./AGT.GalacticArchives.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AGT.GalacticArchives.Api.dll"]
