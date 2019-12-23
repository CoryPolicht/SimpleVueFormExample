FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["SimpleDotNetWebServiceExample/SimpleDotNetWebServiceExample.csproj", "SimpleDotNetWebServiceExample/"]
RUN dotnet restore "SimpleDotNetWebServiceExample/SimpleDotNetWebServiceExample.csproj"
COPY . .
WORKDIR "/src/SimpleDotNetWebServiceExample"
RUN dotnet build "SimpleDotNetWebServiceExample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SimpleDotNetWebServiceExample.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SimpleDotNetWebServiceExample.dll"]