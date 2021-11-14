# Stage 1
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /build
COPY . .
RUN dotnet restore "src/Gulliver.Busca.Api/Gulliver.Busca.Api.csproj"
RUN dotnet publish "src/Gulliver.Busca.Api/Gulliver.Busca.Api.csproj" -c Release -o /app

# Stage 2
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS final
WORKDIR /app
COPY --from=build /app .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Gulliver.Busca.Api.dll