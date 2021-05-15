@echo off

call Environment.bat

dotnet test %CSPROJ_TESTS%
