FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

RUN apt-get update --allow-releaseinfo-change && \
    apt-get install -y \
      openjdk-11-jdk \
      ca-certificates-java && \
    apt-get clean;

RUN update-ca-certificates -f
ENV JAVA_HOME /usr/lib/jvm/java-11-openjdk-amd64/
RUN export JAVA_HOME

ARG APP_ENV="Local"
ENV ASPNETCORE_ENVIRONMENT ${APP_ENV}

ARG API_VERSION="latest"
ENV API_VERSION ${API_VERSION}
ENV SERVICE_NAME="dotnet-project"

WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./

RUN sed -i 's/\r$//' run-dev.bash

RUN dotnet publish -c Release -o out

EXPOSE 8080