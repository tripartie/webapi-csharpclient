@echo off

call Environment.bat

dotnet pack %CSPROJ_PACKAGE% --output %OUTPUT_PACKAGE% --configuration Release --include-symbols -p:SymbolPackageFormat=snupkg -p:FileVersion=%VERSION% -p:Version=%VERSION% -p:AssemblyVersion=%VERSION%
