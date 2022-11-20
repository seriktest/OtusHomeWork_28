FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["OtusHomeWork_28/OtusHomeWork_28.csproj", "OtusHomeWork_28/"]
RUN dotnet restore "OtusHomeWork_28/OtusHomeWork_28.csproj"
COPY . .
WORKDIR "/src/OtusHomeWork_28"
RUN dotnet build "OtusHomeWork_28.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OtusHomeWork_28.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OtusHomeWork_28.dll"]
