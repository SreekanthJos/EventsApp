FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
 

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["EventsApp.EventInfo.API/EventsApp.EventInfo.API.csproj", "EventsApp.EventInfo.API/"]

RUN dotnet restore "EventsApp.EventInfo.API/EventsApp.EventInfo.API.csproj"
COPY . .
WORKDIR "/src/EventsApp.EventInfo.API"
RUN dotnet build "EventsApp.EventInfo.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "EventsApp.EventInfo.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EventsApp.EventInfo.API.dll"]