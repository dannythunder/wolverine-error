FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Wolverine/Wolverine.csproj", "Wolverine/"]
RUN dotnet restore "Wolverine/Wolverine.csproj"
COPY . .
WORKDIR "/src/Wolverine"
RUN dotnet build "Wolverine.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Wolverine.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Wolverine.dll"]
