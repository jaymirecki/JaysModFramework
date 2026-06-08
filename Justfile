set windows-shell := ["cmd.exe", "/c"]

gta_dir := "E:\\Program Files (x86)\\SteamLibrary\\steamapps\\common\\Grand Theft Auto V"

build:
    dotnet build src/JaysModFramework.Core/JaysModFramework.Core.csproj
    dotnet build src/JaysModFramework.Rph/JaysModFramework.Rph.csproj

pack:
    dotnet build src/JaysModFramework.Core/JaysModFramework.Core.csproj --configuration Release
    dotnet build src/JaysModFramework.Rph/JaysModFramework.Rph.csproj --configuration Release
    cp src/JaysModFramework.Core/bin/Release/netstandard2.0/JaysModFramework.Core.dll dist/
    cp src/JaysModFramework.Rph/bin/Release/net48/JaysModFramework.Rph.dll dist/Plugins/

[unix]
run: pack
    cp -r dist/. "{{gta_dir}}/"

[windows]
run: pack
    powershell -NoProfile -Command Copy-Item -Recurse -Force dist\* '{{gta_dir}}\'

test:
    dotnet test tests/JaysModFramework.Tests/JaysModFramework.Tests.csproj
