@echo off

call Environment.bat

dotnet nuget push %OUTPUT_PACKAGE%%NAME_PACKAGE%.%VERSION%.nupkg --source %NUGET_SOURCE%