FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Application/HiNoIshi.App/HiNoIshi.App.csproj", "HiNoIshi.App/"]
RUN dotnet restore "Application/HiNoIshi.App/HiNoIshi.App.csproj"
COPY . .
WORKDIR "/src/HiNoIshi.App"
RUN dotnet build "HiNoIshi.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HiNoIshi.App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HiNoIshi.App.dll"]
