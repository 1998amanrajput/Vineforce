FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Vineforce.CandidateTest.Web.Host/Vineforce.CandidateTest.Web.Host.csproj", "src/Vineforce.CandidateTest.Web.Host/"]
COPY ["src/Vineforce.CandidateTest.Web.Core/Vineforce.CandidateTest.Web.Core.csproj", "src/Vineforce.CandidateTest.Web.Core/"]
COPY ["src/Vineforce.CandidateTest.Application/Vineforce.CandidateTest.Application.csproj", "src/Vineforce.CandidateTest.Application/"]
COPY ["src/Vineforce.CandidateTest.Core/Vineforce.CandidateTest.Core.csproj", "src/Vineforce.CandidateTest.Core/"]
COPY ["src/Vineforce.CandidateTest.EntityFrameworkCore/Vineforce.CandidateTest.EntityFrameworkCore.csproj", "src/Vineforce.CandidateTest.EntityFrameworkCore/"]
WORKDIR "/src/src/Vineforce.CandidateTest.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Vineforce.CandidateTest.Web.Host", "src/Vineforce.CandidateTest.Web.Host"]
COPY ["src/Vineforce.CandidateTest.Web.Core", "src/Vineforce.CandidateTest.Web.Core"]
COPY ["src/Vineforce.CandidateTest.Application", "src/Vineforce.CandidateTest.Application"]
COPY ["src/Vineforce.CandidateTest.Core", "src/Vineforce.CandidateTest.Core"]
COPY ["src/Vineforce.CandidateTest.EntityFrameworkCore", "src/Vineforce.CandidateTest.EntityFrameworkCore"]
WORKDIR "/src/src/Vineforce.CandidateTest.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Vineforce.CandidateTest.Web.Host.dll"]
