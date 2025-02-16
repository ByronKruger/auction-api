ARG DOTNET_RUNTIME=mcr.microsoft.com/dotnet/aspnet:8.0
ARG DOTNET_SDK=mcr.microsoft.com/dotnet/sdk:8.0

FROM ${DOTNET_RUNTIME} AS base1
# ENV ASPNETCORE_URLS=http://+:7105
WORKDIR /source
# EXPOSE 7105

# Base for build
FROM ${DOTNET_SDK} AS buildbase1
WORKDIR /source

# COPY *.sln .
# COPY *.csproj ./
# RUN dotnet restore

# COPY ["SolutionService.sln", "./"]
# COPY ["src/Api/Api.csproj", "src/Api/Api.csproj"]
# COPY ["src/Domain/Domain.csproj", "src/Domain/Domain.csproj"]
# COPY ["src/Infrastructure/Infrastructure.csproj", "src/Infrastructure/Infrastructure.csproj"]

# COPY ["tests/Unit/Unit.csproj", "tests/Unit/Unit.csproj"]

COPY ../ .
# COPY ["src/", "src/"]
# COPY ["tests/", "tests/"]

## Run migrations
FROM buildbase1 as migrations1
# RUN dotnet tool install --version 6.0.9 --global dotnet-ef
RUN dotnet tool install --global dotnet-ef
CMD dotnet-ef database drop --force
ENV PATH="$PATH:/root/.dotnet/tools"
# ENTRYPOINT dotnet-ef database update --project src/Infrastructure/ --startup-project src/Api/
ENTRYPOINT dotnet-ef database update