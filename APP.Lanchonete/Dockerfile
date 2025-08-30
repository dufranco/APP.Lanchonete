# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base

ARG CACHEBUST=1
RUN echo "$CACHEBUST"

# Instala suporte a locale pt_BR.UTF-8
RUN apk --no-cache add icu-libs tzdata \
    && apk add --no-cache --virtual .build-deps icu-data-full \
    && cp /usr/share/zoneinfo/America/Sao_Paulo /etc/localtime \
    && echo "America/Sao_Paulo" > /etc/timezone \
    && apk del .build-deps \
    && echo "pt_BR.UTF-8 UTF-8" > /etc/locale.gen \
    && echo "LANG=pt_BR.UTF-8" > /etc/locale.conf \
    && export LANG=pt_BR.UTF-8

ENV LANG=pt_BR.UTF-8
ENV LC_ALL=pt_BR.UTF-8
ENV TZ=America/Sao_Paulo

USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["APP.Lanchonete/APP.Lanchonete.csproj", "APP.Lanchonete/"]
RUN dotnet --no-cache restore "./APP.Lanchonete/APP.Lanchonete.csproj"
COPY . .
WORKDIR "/src/APP.Lanchonete"
RUN dotnet --no-cache build  "./APP.Lanchonete.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet --no-cache publish "./APP.Lanchonete.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "APP.Lanchonete.dll"]