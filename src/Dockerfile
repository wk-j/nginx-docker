FROM microsoft/dotnet:2.1-sdk
WORKDIR /app

COPY publish /app

RUN find /app

ENV ASPNETCORE_URLS http://+:5000
EXPOSE 5000

ENTRYPOINT [ "dotnet", "MyApp.dll" ]