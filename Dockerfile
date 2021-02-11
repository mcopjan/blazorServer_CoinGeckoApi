FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5050

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY CoinGeckoApi_Blazor.csproj .
RUN dotnet restore "CoinGeckoApi_Blazor.csproj"
COPY . .
RUN dotnet build "CoinGeckoApi_Blazor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CoinGeckoApi_Blazor.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CoinGeckoApi_Blazor.dll"]