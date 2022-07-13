#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["seller-shop.Main/seller-shop.Main.csproj", "seller-shop.Main/"]
RUN dotnet restore "seller-shop.Main/seller-shop.Main.csproj"
COPY . .
WORKDIR "/src/seller-shop.Main"
RUN dotnet build "seller-shop.Main.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "seller-shop.Main.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "seller-shop.Main.dll"]
