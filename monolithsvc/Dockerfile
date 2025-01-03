 # Sample contents of Dockerfile (another test)
 # Stage 1
 FROM mcr.microsoft.com/dotnet/sdk:9.0 AS builder
 WORKDIR /source

 # caches restore result by copying csproj file separately
 COPY *.csproj .
 RUN dotnet restore

 # copies the rest of your code
 COPY . .
 RUN find -type d -name bin -prune -exec rm -rf {} \; && find -type d -name obj -prune -exec rm -rf {} \;
 RUN dotnet publish --output /app/ --configuration Release

 # Stage 2
 FROM mcr.microsoft.com/dotnet/aspnet:9.0
 RUN apt-get update

 RUN adduser non-root-user
 
 USER non-root-user
 
 WORKDIR /app
 COPY --from=builder /app .
 ENTRYPOINT ["dotnet", "monolithsvc.dll"]
