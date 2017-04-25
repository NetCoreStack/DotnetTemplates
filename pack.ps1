dotnet restore NetCoreStack.DotnetTemplates.sln
dotnet build NetCoreStack.DotnetTemplates.sln
cd src/Hisar.Component.Template
dotnet pack -o ../../nupkg --version-suffix preview1 -c Release
