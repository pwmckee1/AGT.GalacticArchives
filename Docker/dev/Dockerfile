FROM mcr.microsoft.com/dotnet/sdk:10.0-alpine AS build
WORKDIR /app

COPY ./ .
RUN dotnet restore
RUN dotnet publish /app/AGT.GalacticArchives.Api/AGT.GalacticArchives.Api.csproj -o out --no-restore

FROM mcr.microsoft.com/dotnet/sdk:10.0-alpine AS aspnet

WORKDIR /app

COPY --from=build /app/out ./
COPY --from=build /app/Docker/dev/cert-aspnetcore.pfx ./

EXPOSE 80
EXPOSE 443

ENTRYPOINT ["dotnet", "AGT.GalacticArchives.Api.dll"]