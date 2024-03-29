﻿# Taken from psake https://github.com/psake/psake

# Clear Release folder
Remove-Item -Path ..\src\bin\Release\*.nupkg
dotnet clean ..\src\OkoloIt.Utilities.Result.csproj -c Release;

# Build Project
dotnet build ..\src\OkoloIt.Utilities.Result.csproj -c Release;
dotnet pack ..\src\OkoloIt.Utilities.Result.csproj -c Release;