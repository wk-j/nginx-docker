FROM microsoft/dotnet:2.1-sdk
WORKDIR /app

COPY publish /app

RUN find /app

ENTRYPOINT [ "dotnet", "MyApp.dll" ]