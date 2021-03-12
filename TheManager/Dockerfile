#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TheManager/TheManager.csproj", "TheManager/"]
RUN dotnet restore "TheManager/TheManager.csproj"
COPY . .
WORKDIR "/src/TheManager"
RUN dotnet build "TheManager.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TheManager.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN dotnet dev-certs https
RUN dotnet dev-certs https --trust
ENTRYPOINT ["dotnet", "TheManager.dll"]
