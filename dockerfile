# Stage 1
FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS build
WORKDIR /build
COPY . .
RUN dotnet restore
RUN dotnet publish "src/Gulliver.Busca.Api/Gulliver.Busca.Api.csproj" -c Release -o /app

# Stage 2
FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine AS final
WORKDIR /app
COPY --from=build /app .
EXPOSE 5000
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Gulliver.Busca.Api.dll