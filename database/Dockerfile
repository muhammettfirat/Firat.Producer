FROM mcr.microsoft.com/dotnet/core/sdk:7.0 AS build
COPY . .

WORKDIR /templates/service/host/IdentityServerHost
RUN dotnet restore
RUN dotnet ef migrations script -i -o migrations-IdentityServerHost.sql

WORKDIR /templates/service/host/Firat.Producer.Host
RUN dotnet restore
RUN dotnet ef migrations script -i -o migrations-Producer.sql

FROM mcr.microsoft.com/mssql-tools AS final
WORKDIR /src
COPY --from=build /templates/service/host/IdentityServerHost/migrations-IdentityServerHost.sql migrations-IdentityServerHost.sql
COPY --from=build /templates/service/host/Firat.Producer.Host/migrations-Producer.sql migrations-Producer.sql
COPY --from=build /templates/service/database/entrypoint.sh .
RUN /bin/bash -c "sed -i $'s/\r$//' entrypoint.sh"
RUN chmod +x ./entrypoint.sh

ENTRYPOINT ["./entrypoint.sh"]