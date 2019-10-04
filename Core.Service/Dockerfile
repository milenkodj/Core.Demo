FROM mcr.microsoft.com/dotnet/core/runtime:3.0-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Core.Service/Core.Service.csproj", "Core.Service/"]
COPY ["Core.Domain/Core.Domain.csproj", "Core.Domain/"]
RUN dotnet restore "Core.Service/Core.Service.csproj"
COPY . .
WORKDIR "/src/Core.Service"
RUN dotnet build "Core.Service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Core.Service.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Core.Service.dll"]