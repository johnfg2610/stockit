#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Container we use for final publish
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Build container
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build

# Copy the code into the container
WORKDIR /src
COPY ["src/Johnfg2610.Stockit/Johnfg2610.Stockit.csproj", "Johnfg2610.Stockit/"]

# NuGet restore
RUN dotnet restore "Johnfg2610.Stockit/Johnfg2610.Stockit.csproj"
COPY ["src/Johnfg2610.Stockit/", "Johnfg2610.Stockit/"]

# Build the API
WORKDIR "Johnfg2610.Stockit"
RUN dotnet build "Johnfg2610.Stockit.csproj" -c Release -o /app/build

# Publish it
FROM build AS publish
RUN dotnet publish "Johnfg2610.Stockit.csproj" -c Release -o /app/publish

# Make the final image for publishing
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Johnfg2610.Stockit.dll"]
