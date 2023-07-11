#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Container we use for final publish
FROM mcr.microsoft.com/dotnet/core/aspnet:6.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Build container
FROM mcr.microsoft.com/dotnet/core/sdk:6.0-buster AS build

# Copy the code into the container
WORKDIR /
COPY ["/Map.Service/Map.Service.csproj", "Map.Service/"]

# NuGet restore
RUN dotnet restore "Map.Service/Map.Service.csproj"
COPY ["/Map.Service/", "Map.Service/"]

# Build the API
WORKDIR "Map.Service"
RUN dotnet build "Map.Service.csproj" -c Release -o /app/build

# Publish it
FROM build AS publish
RUN dotnet publish "Map.Service.csproj" -c Release -o /app/publish

# Make the final image for publishing
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Map.Service.dll"]
