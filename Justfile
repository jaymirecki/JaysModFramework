build:
    dotnet build src/JaysModFramework.Rph/JaysModFramework.Rph.csproj

pack:
    dotnet build src/JaysModFramework.Rph/JaysModFramework.Rph.csproj --configuration Release
    cp src/JaysModFramework.Rph/bin/Release/net48/JaysModFramework.Rph.dll dist/

test:
    dotnet test tests/JaysModFramework.Tests/JaysModFramework.Tests.csproj
