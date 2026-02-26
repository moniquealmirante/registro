# Dockerfile
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app

# Copiar csproj e restaurar pacotes
COPY *.csproj ./
RUN dotnet restore

# Copiar todo o código e publicar
COPY . ./
RUN dotnet publish -c Release -o /app/publish

# Imagem final
FROM mcr.microsoft.com/dotnet/aspnet:10.0
COPY --from=build /app/publish .
EXPOSE 80
EXPOSE 443


ENTRYPOINT ["dotnet", "registro.dll"]