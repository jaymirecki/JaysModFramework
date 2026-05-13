set windows-shell := ["cmd.exe", "/c"]

gta_dir := "E:\\Program Files (x86)\\SteamLibrary\\steamapps\\common\\Grand Theft Auto V"

build:
    dotnet build src/JaysModFramework.Rph/JaysModFramework.Rph.csproj

pack:
    dotnet build src/JaysModFramework.Rph/JaysModFramework.Rph.csproj --configuration Release
    cp src/JaysModFramework.Rph/bin/Release/net48/JaysModFramework.Rph.dll dist/

[unix]
run: pack
    cp dist/JaysModFramework.Rph.dll "{{gta_dir}}/plugins/"

[windows]
run: pack
    copy dist\JaysModFramework.Rph.dll "{{gta_dir}}\plugins\"

test:
    dotnet test tests/JaysModFramework.Tests/JaysModFramework.Tests.csproj
