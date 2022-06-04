#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 44349
EXPOSE 443
ENV ASPNETCORE_URLS=http://*:44349


FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["EmployeeSkill.csproj", "."]
RUN dotnet restore "EmployeeSkill.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "EmployeeSkill.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EmployeeSkill.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EmployeeSkill.dll"]
