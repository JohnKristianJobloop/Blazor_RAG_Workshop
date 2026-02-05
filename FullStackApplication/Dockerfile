FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_ID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
COPY ["FullStackApplication/FullStackApplication.csproj", "FullStackApplication/"]
RUN dotnet restore "FullStackApplication/FullStackApplication.csproj"
COPY . .
WORKDIR "FullStackApplication"
RUN dotnet build "./FullStackApplication.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./FullStackApplication.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FullStackApplication.dll"]

