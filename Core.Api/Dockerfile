FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Core.Api/Core.Api.csproj", "Core.Api/"]
RUN dotnet restore "Core.Api/Core.Api.csproj"
COPY . .
WORKDIR "/src/Core.Api"
RUN dotnet build "Core.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Core.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Core.Api.dll"]