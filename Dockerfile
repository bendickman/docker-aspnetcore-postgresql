FROM mcr.microsoft.com/dotnet/sdk:2.1 AS build
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore dockerapi.csproj

COPY . ./
RUN dotnet publish dockerapi.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:2.1 AS runtime

WORKDIR /app

COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "dockerapi.dll"]`