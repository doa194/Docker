FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /home/site/wwwroot
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish -c Release -o /home/site/wwwroot

FROM base AS final
COPY --from=build /home/site/wwwroot .
ENV AzureWebJobsScriptRoot=/home/site/wwwroot \
    AzureFunctionsJobHost__Logging__Console__IsEnabled=true
ENTRYPOINT ["dotnet", "MyFunctionApp.dll"]