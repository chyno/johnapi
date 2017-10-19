# Build stage
FROM microsoft/aspnetcore-build:2 AS build-env

WORKDIR /johnapi

# restore
copy johnapi/johnapi.csproj ./api/
RUN dotnet restore api/johnapi.csproj

copy tests/tests.csproj ./tests/
RUN dotnet restore tests/tests.csproj

RUN ls -alR

# copy src
copy . .

# test
RUN dotnet test tests/tests.csproj

# publish
RUN dotnet publish johnapi/johnapi.csproj -o /publish

# Runtime stage
FROM microsoft/aspnetcore:2
COPY --from=build-env /publish /publish
WORKDIR /publish
ENTRYPOINT ["dotnet", "johnapi.dll"]