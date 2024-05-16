
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ContentDistributionPlatform/ContentDistributionPlatform.csproj", "ContentDistributionPlatform/"]
RUN dotnet restore "ContentDistributionPlatform/ContentDistributionPlatform.csproj"
COPY . .
WORKDIR "/src/ContentDistributionPlatform"
RUN dotnet build "ContentDistributionPlatform.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ContentDistributionPlatform.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ContentDistributionPlatform.dll"]
