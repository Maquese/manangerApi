FROM microsoft/dotnet:2.1-sdk as build


WORKDIR /app

WORKDIR /app/ManangerAPI

COPY ./ManangerAPI .

WORKDIR /app/manangerapi.application

COPY ./ManangerAPI.Application .

COPY ./ManangerAPI.Application/*csproj ./manangerapi.application.csproj

WORKDIR /app/manangerapi.data

COPY ./ManangerAPI.Data .

COPY ./ManangerAPI.Data/*csproj ./ManangerApi.Data.csproj

WORKDIR /app/ManangerAPI

#RUN dotnet restore 

RUN dotnet build

WORKDIR /app/ManangerAPI/

RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.1
WORKDIR /app
COPY --from=build /app/ManangerAPI/out .
ENTRYPOINT ["dotnet", "ManangerApi.dll"]



# COPY ./ManangerAPI.Data/*.csproj ./
# RUN  dotnet restore  src/ManangerAPI.Data.csproj


# COPY ManangerAPI.Application/*.csproj ./
# RUN  dotnet restore /app/ManangerAPI.Application.csproj

# COPY . ./
# RUN dotnet publish -c release -o out

# FROM mcr.microsoft.com/dotnet/core/aspnet:2.1
# WORKDIR /app
# EXPOSE 80
# COPY --from=build-env /app/out .
# ENTRYPOINT [ "manangerapi.dll" ]