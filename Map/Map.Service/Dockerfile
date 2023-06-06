FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_URLS=http://+:80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Map/Map.Service/Map.Service.csproj", "Map/Map.Service/"]
RUN dotnet restore "Map/Map.Service/Map.Service.csproj"
COPY . .
WORKDIR "/src/Map/Map.Service"
RUN dotnet build "Map.Service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Map.Service.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Map.Service.dll"]
