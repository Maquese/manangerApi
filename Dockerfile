FROM mcr.microsoft.com/dotnet/core/sdk:2.1 


COPY ManangerApi/bin/Release/netcoreapp2.1/publish/ ./

ENTRYPOINT ["dotnet", "manangerapi.dll"]





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